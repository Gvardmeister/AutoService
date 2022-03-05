using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Model
{
    public class QueueCar
    {
        private static int Counter; // Счетчик созданных объектов 
        private int _ID; // Уникаольный индетификатор
        private int _QueueNeedService; // Очередь на необходимый сервис
        private List<Car> _Queue = new List<Car>(); // Список всех обычных автомобилей находящихся в очереди
        private List<Car> _QueuePriority = new List<Car>(); // Список всех приоритетных автомобилей находящихся в очереди
        private ListBox _ListBox; // Визуальный компонент
        private ListBox _ListBoxPrior; // Визуальный компонент
        private string _Name; // Поле требуемое для отображения

        // Конструктор класса
        public QueueCar(int QueueNeedService, ListBox LB, ListBox LBPrior)
        {
            _ID = ++Counter;

            if(QueueNeedService >= 0 && QueueNeedService < Services.Types.Length)
            {
                _QueueNeedService = QueueNeedService;
            }

            if(LB != null)
            {
                _ListBox = LB;
            }

            if(LBPrior != null)
            {
                _ListBoxPrior = LBPrior;
            }

            _Name = $"[{_ID}]Очередь - {Services.Types[_QueueNeedService].Name}";
        }

        // Конструктор по умолчанию для класса QueueCar
        public QueueCar() : this(0, null, null) { }
        
        // Метод для корректного отображения 
        public override string ToString()
        {
            return _Name;
        }

        // Свойство для доступа к индетификатору очереди
        public int ID
        {
            get
            {
                return _ID;
            }
        }

        // Свойство для доступа к очереди в необходимый сервис
        public int QueueNeedService
        {
            get
            {
                return _QueueNeedService;
            }
        }

        // Создание события первого автомобиля в очереди 
        public event EventHandler<OnlyPrintArgs> SingleAutoEvent;

        // Активатор события SingleAutoEvent
        private void OnSingleAuto(AutoArgs autoArgs)
        {
            if (SingleAutoEvent != null && (_Queue.Count == 1 || _QueuePriority.Count == 1))
            {
                OnlyPrintArgs onlyPrintArgs = new OnlyPrintArgs
                {
                    PrintResult = autoArgs.PrintResult,
                    Manager = autoArgs.Manager
                };

                SingleAutoEvent(this, onlyPrintArgs);
            }
        }

        // Обработчик события "Новый автомобиль"
        public void NewAuto(object sender, AutoArgs autoArgs)
        {
            if (autoArgs.Automobile != null)
            {   
                if (autoArgs.Automobile.PriorityCar)
                {
                    _QueuePriority.Add(autoArgs.Automobile);

                    if (_ListBoxPrior != null)
                    {
                        _ListBoxPrior.Items.Add(autoArgs.Automobile);
                    }
                }
                else
                {
                    _Queue.Add(autoArgs.Automobile);

                    if (_ListBox != null)
                    {
                        _ListBox.Items.Add(autoArgs.Automobile);
                    }
                }

                autoArgs.PrintResult?.Invoke(this + $": добавлен '{autoArgs.Automobile}'");
                autoArgs.Automobile = null;
                OnSingleAuto(autoArgs);
            }
        }

        // Метод для удаления из списка очереди автомобиля по уникальному индетификатору
        private void RemoveFromList(List<Car> CarList, Car Car)
        {
            for (int i = 0; i < CarList.Count; i++)
            {
                if (CarList[i].ID == Car.ID)
                {
                    CarList.RemoveAt(i);
                    break;
                }
            }
        }

        // Обработчик события на удаление из очереди
        public void RemoveFromQueue(object sender, AutoArgs autoArgs)
        {
            if (autoArgs.Automobile.PriorityCar)
            {
                RemoveFromList(_QueuePriority, autoArgs.Automobile);

                if (_ListBoxPrior != null)
                {
                    _ListBoxPrior.Items.Remove(autoArgs.Automobile);
                }
            }
            else
            {
                RemoveFromList(_Queue, autoArgs.Automobile);

                if (_ListBox != null)
                {
                    _ListBox.Items.Remove(autoArgs.Automobile);
                }
            }
        }

        // Обработчик события "Место обслуживания"
        public void SetService(object sender, ServiceArgs serviceArgs)
        {
            if ((_QueuePriority.Count > 0 || _Queue.Count > 0) && serviceArgs.IsReady)
            {
                AutoArgs autoArgs = new AutoArgs();

                if (_QueuePriority.Count > 0)
                {
                    autoArgs.Automobile = _QueuePriority[0];
                    _QueuePriority.RemoveAt(0);

                    if (_ListBoxPrior != null)
                    {
                        _ListBoxPrior.Items.Remove(autoArgs.Automobile);
                    }
                }
                else if (_Queue.Count > 0)
                {
                    autoArgs.Automobile = _Queue[0];
                    _Queue.RemoveAt(0);

                    if (_ListBox != null)
                    {
                        _ListBox.Items.Remove(autoArgs.Automobile);
                    }
                }

                serviceArgs.PrintResult?.Invoke(this + $": покинул очередь '{autoArgs.Automobile}'");
                serviceArgs.IsReady = serviceArgs.SetService(autoArgs);
            }
        }
    }
}
