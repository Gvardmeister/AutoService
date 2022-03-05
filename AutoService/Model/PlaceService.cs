using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Model
{
    public class PlaceService
    {
        private static int Counter; // Счетчик созданных объектов   
        private int _ID; // Уникальный индетификатор
        private int _NeedService; // Необходимый сервис для автомобиля
        private TextBox _TB; // Визуальный компонент
        private Car _Current; // Текущая машина (обслуживаемая)
        private string _Name; // Поле требуемое для отображения 
        private int _TimeStep; // Временной шаг равный 1 минуте

        // Событие для удаления автомобиля из очередей
        public event EventHandler<AutoArgs> RemoveFromQuequeEvent;

        // Событие поступления автомобиля с определенным типом сервиса
        public event EventHandler<AutoArgs> NewAutoWasherEvent, NewAutoReplacingEvent, NewAutoBalanceEvent, NewAutoCheckEvent;

        // Констуктор класса
        public PlaceService(int NeedService, TextBox TB, int TimeStep)
        {
            _ID = ++Counter;
            _TimeStep = TimeStep;
            _NeedService = NeedService;
            _Name = $"Сервис {_ID} {_NeedService}";
            _TB = TB;

            if (_TB != null)
            {
                TB.Clear();
            }
        }

        // Констуктор класса по умолчанию для класса PlaceService
        public PlaceService() : this(0, null, 1) { }

        // Метод для распределния автомобиля по необходимым сервисам
        public void Distribution(AutoArgs autoArgs)
        {
            if (autoArgs.Automobile != null && autoArgs.Automobile.CurrentService == -1)
            {
                if (autoArgs.Automobile.GetCountServices() > 0)
                {
                    List<PlaceService> PlaceServices = autoArgs.Manager.GetPlaceService();
                    List<CarService> CurrentServices = autoArgs.Automobile.GetNeedService();

                    if (CurrentServices[0].Index == 0)
                    {
                        PlaceServices[0].NewAutoWasherEvent?.Invoke(this, autoArgs);
                    }
                    else
                    {
                        for (int i = 1; i < PlaceServices.Count(); i++)
                        {
                            for (int j = 0; j < CurrentServices.Count(); j++)
                            {
                                if (PlaceServices[i].NeedServices == CurrentServices[j].Index)
                                {
                                    if (PlaceServices[i].NeedServices == 1)
                                    {
                                        PlaceServices[i].NewAutoReplacingEvent?.Invoke(this, autoArgs);
                                    }
                                    else if (PlaceServices[i].NeedServices == 2)
                                    {
                                        PlaceServices[i].NewAutoBalanceEvent?.Invoke(this, autoArgs);
                                    }
                                    else
                                    {
                                        PlaceServices[i].NewAutoCheckEvent?.Invoke(this, autoArgs);
                                    }

                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Метод для корректного отображения
        public override string ToString()
        {
            return _Name;
        }

        // Свойство для доступа к уникальному индетификатору
        public int ID
        {
            get
            {
                return _ID;
            }
        }

        // Свойство для доступа к необходимому полю
        public int NeedServices
        {
            get
            {
                return _NeedService;
            }
        }

        // Метод для установки автомобиля на сервис
        private bool SetAuto(AutoArgs autoArgs)
        {
            if (autoArgs.Automobile != null && autoArgs.Automobile.CurrentService == -1)
            {
                if (_Current == null)
                {
                    if (autoArgs.Automobile[0].Index == 0 && _NeedService == 0)
                    {
                        autoArgs.Automobile.CurrentService = 0;
                        autoArgs.Automobile.TimeProcessing = autoArgs.Automobile[0].Time;
                        autoArgs.Automobile.Time = autoArgs.Automobile[0].Time;
                    }
                    else
                    {
                        autoArgs.Automobile.CurrentService = _NeedService;

                        int CountServices = autoArgs.Automobile.GetCountServices();

                        for (int i = 0; i < CountServices; i++)
                        {
                            if (autoArgs.Automobile[i].Index == _NeedService)
                            {
                                autoArgs.Automobile.TimeProcessing = autoArgs.Automobile[i].Time;
                                autoArgs.Automobile.Time = autoArgs.Automobile[i].Time;
                                break;
                            }
                        }
                    }

                    _Current = autoArgs.Automobile;

                    RemoveFromQuequeEvent?.Invoke(this, autoArgs);

                    if(_TB != null)
                    {
                        _TB.Text = autoArgs.Automobile.ToString();
                    }

                    autoArgs.PrintResult?.Invoke(this + $": поступил в сервис '{autoArgs.Automobile}'");
                }
            }
            else
            {
                autoArgs.PrintResult?.Invoke(this + $": '{autoArgs.Automobile}' услуга занята, выполнение не удалось или неправильно выбран тип услуги");
            }

            return _Current == null;
        }

        // Событие о том, свободен ли сервис
        public event EventHandler<ServiceArgs> IsReadyEvent;

        // Метод для получания информации о том, готов ли сервис принять автомобиль
        private void OnIsReady(CalcBack PrintResult)
        {
            if (IsReadyEvent != null && _Current == null)
            {
                ServiceArgs serviceArgs = new ServiceArgs
                {
                    PrintResult = PrintResult,
                    SetService = SetAuto,
                    IsReady = true
                };

                IsReadyEvent(this, serviceArgs);
            }
        }

        // Обработчик события "Шаг"
        public void RunTime(object sender, LogArgs logArgs)
        {
            if (_Current != null)
            {
                int TimeRemaining = _Current.SubstractTime(_TimeStep);

                if (_Current.TimeProcessing == 0)
                {
                    logArgs.PrintLog?.Invoke(new FactService(_NeedService, _Current.Time, _Current.PriorityCar ? 1 : 0));

                    if (_TB != null)
                    {
                        _TB.Clear();
                    }

                    logArgs.PrintResult?.Invoke(this + $": покинул сервис '{_Current}'");

                    if (_Current.CurrentService != -1)
                    {
                        int CountServices = _Current.GetCountServices();

                        for (int i = 0; i < CountServices; i++)
                        {
                            if (_Current[i].Index == _Current.CurrentService)
                            {
                                _Current.RemoveServiceByIndex(i);
                                break;
                            }
                        }
                    }

                    _Current.CurrentService = -1;

                    Distribution(new AutoArgs { Automobile = _Current, PrintResult = logArgs.PrintResult, Manager = logArgs.Manager });

                    _Current = null;

                    OnIsReady(logArgs.PrintResult);
                }
                else
                {
                    logArgs.PrintResult?.Invoke(this + $": {_Current} оставшееся время: {TimeRemaining} мин");

                    if (_TB != null)
                    {
                        _TB.Text = _Current.ToString();
                    }
                }
            }
        }

        // Обработчик события "Первый автомобиль в очереди"
        public void WaitSingle(object sender, OnlyPrintArgs onlyPrintArgs)
        {
            // Если сервис свободен, тогда он сообщает о том, что готов принять автомобиль
            OnIsReady(onlyPrintArgs.PrintResult);
        }
    }
}
