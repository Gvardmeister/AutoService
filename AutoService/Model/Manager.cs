using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Model
{
    public class Manager
    {
        private List<QueueCar> queueCars = new List<QueueCar>(); // Список всех существующих очередей
        private List<PlaceService> placeServices = new List<PlaceService>(); // Список всех существующих сервисов
        private List<FactService> factServices = new List<FactService>(); // Список всех выполненых сервисов

        private Random random = new Random(); 
        private TextBox _LogAuto_TB, _LinQ_TB; // Визуальные компоненты

        private int _Chance = 1; // Значение по умолчанию
        private int _CountAuto = 1; // Значение по умолчанию

        // Конструктор класса
        public Manager(TextBox LogAuto_TB, TextBox LinQ_TB)
        {
            _LogAuto_TB = LogAuto_TB;
            _LinQ_TB = LinQ_TB;
        }

        // Конструктор по умолчанию для класса Manager
        public Manager() : this(null, null) { }

        // Свойство для доступа к шансу (вероятности)
        public int Chance
        {
            set
            {
                if(value > 0 && value <= 100)
                {
                    _Chance = value;
                }
            }
        }

        // Свойство для доступа к количеству автомобилей
        public int CountAuto
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    _CountAuto = value;
                }      
            }
        }

        // Активатор события "Новый автомобиль"
        private void OnNewAuto()
        {
            // Генерируем количество сервисов
            int CountServices = 1 + random.Next(1, 4);

            List<CarService> TempServices = new List<CarService>();

            // Генерируем сервисы
            TempServices.Add(new CarService(0, random.Next(1, 6)));

            if (CountServices > 1)
            {  
                for (int i = 1; i < CountServices; i++)
                {
                    int ValueService = -1;

                    while (true)
                    {
                        bool ValueServiceOk = true;
                        ValueService = random.Next(1, Services.Types.Length);

                        if (i > 1)
                        {
                            for (int j = i - 1; j >= 0; j--)
                            {
                                if (TempServices[j].Index == ValueService)
                                {
                                    ValueServiceOk = false;
                                    break;
                                }
                            }
                        }

                        if (ValueServiceOk)
                        {
                            break;
                        }
                    }

                    if (ValueService != -1)
                    {
                        TempServices.Add(new CarService(ValueService, random.Next(3, 7)));
                    }
                }
            }

            // генерируем вероятность приоритетности
            int priority = random.Next(1, 101) / 4;

            if (priority > 20)
            {
                priority = 1;
            }
            else
            {
                priority = 0;
            }

            AutoArgs autoArgs = new AutoArgs
            {
                Automobile = new Car(TempServices, TempServices[0].Time, TempServices[0].Time, -1, priority != 0),
                Manager = this
            };

            autoArgs.PrintResult = PrintResult;

            placeServices[0].Distribution(autoArgs);
        }

        // Событие "Шаг"
        private event EventHandler<LogArgs> RunTimeEvent;

        // Активатор события "Шаг"
        private void OnRunTime()

        {
            if (RunTimeEvent != null)
            {
                LogArgs logArgs = new LogArgs
                {
                    PrintResult = PrintResult,
                    PrintLog = PrintLog,
                    Manager = this
                };

                RunTimeEvent(this, logArgs);
            }
        }

        // Метод для отображения выполненых действий сервисом
        private void PrintResult(string s)
        {
            if (_LogAuto_TB != null)
            {
                _LogAuto_TB.AppendText(s + Environment.NewLine);
            }
        }

        // Метод для записи логов в LinQ запросе
        private void PrintLog(FactService factservice)
        {
            factServices.Add(factservice);
        }

        // метод для генерации события "Шаг" и событий "Новый автомобиль"
        public void OnTimer()
        {
            _LogAuto_TB.Clear();

            OnRunTime();

            if (random.Next(_Chance) == 0)
            {
                int Count = random.Next(_CountAuto) + 1;

                for (int i = 0; i < Count; i++)
                {
                    OnNewAuto();
                }
            }
        }

        // Метод для добавления новой очереди
        public void AddOueue(QueueCar queueCar)
        {
            queueCars.Add(queueCar);

            // Подписка на события 
            foreach (PlaceService service in placeServices)
            {
                if (service.NeedServices == queueCar.QueueNeedService)
                {
                    service.IsReadyEvent += queueCar.SetService;
                    queueCar.SingleAutoEvent += service.WaitSingle;
                }
            }
        }

        // Меод для удаления очереди
        public void RemoveQueue(QueueCar queueCar)
        {
            queueCars.Remove(queueCar);

            // Отписка события
            foreach (PlaceService service in placeServices)
            {
                if (service.NeedServices == queueCar.QueueNeedService)
                {
                    service.IsReadyEvent -= queueCar.SetService;

                    queueCar.SingleAutoEvent -= service.WaitSingle;
                }
            }
        }

        // Метод для подписок на события
        public void AddService(PlaceService placeservice)
        {
            placeServices.Add(placeservice);

            RunTimeEvent += placeservice.RunTime;

            // Подписка события
            foreach (QueueCar queueCar in queueCars)
            {
                if(placeservice.NeedServices == 0 && queueCar.QueueNeedService == 0)
                {
                    placeservice.NewAutoWasherEvent += queueCar.NewAuto;
                }
                else if(placeservice.NeedServices == 1 && queueCar.QueueNeedService == 1)
                {
                    placeservice.NewAutoReplacingEvent += queueCar.NewAuto;
                }
                else if(placeservice.NeedServices == 2 && queueCar.QueueNeedService == 2)
                {
                    placeservice.NewAutoBalanceEvent += queueCar.NewAuto;
                }
                else if (placeservice.NeedServices == 3 && queueCar.QueueNeedService == 3)
                {
                    placeservice.NewAutoCheckEvent += queueCar.NewAuto;
                }

                if (placeservice.NeedServices == queueCar.QueueNeedService)
                {
                    placeservice.RemoveFromQuequeEvent += queueCar.RemoveFromQueue;
                    queueCar.SingleAutoEvent += placeservice.WaitSingle;
                    placeservice.IsReadyEvent += queueCar.SetService;
                }
            }
        }

        // Метод для отписки события
        public void RemoveService(PlaceService placeservice)
        {
            placeServices.Add(placeservice);

            RunTimeEvent -= placeservice.RunTime;

            // Отписка события
            foreach (QueueCar queueCar in queueCars)
            {
                if (placeservice.NeedServices == 0 && queueCar.QueueNeedService == 0)
                {
                    placeservice.NewAutoWasherEvent -= queueCar.NewAuto;
                }
                else if (placeservice.NeedServices == 1 && queueCar.QueueNeedService == 1)
                {
                    placeservice.NewAutoReplacingEvent -= queueCar.NewAuto;
                }
                else if (placeservice.NeedServices == 2 && queueCar.QueueNeedService == 2)
                {
                    placeservice.NewAutoBalanceEvent -= queueCar.NewAuto;
                }
                else if (placeservice.NeedServices == 3 && queueCar.QueueNeedService == 3)
                {
                    placeservice.NewAutoCheckEvent -= queueCar.NewAuto;
                }

                if (placeservice.NeedServices == queueCar.QueueNeedService)
                {
                    queueCar.SingleAutoEvent -= placeservice.WaitSingle;

                    placeservice.IsReadyEvent -= queueCar.SetService;
                    placeservice.RemoveFromQuequeEvent -= queueCar.RemoveFromQueue;
                }
            }
        }

        public List<PlaceService> GetPlaceService()
        {
            return placeServices;
        }


        // Метод для расчета стастистики сервисов
        public void SetStatService()
        {
            var result = from service in Services.Types
                          join log in factServices on service equals Services.Types[log.ServiceType]
                          into GroupService
                          orderby service.Name
                          select new
                          {
                              ServiceName = service,
                              Priotities = from prior in new int[2] { 0, 1 }
                                           join groups in GroupService on prior equals groups.Priority
                                           into PriorityTimes
                                           orderby prior
                                           select new { PriorityCar = prior, Sum = PriorityTimes.Sum(time => time.TimeService)}
                          };

            _LinQ_TB.Clear();

            foreach (var groups in result)
            {
                _LinQ_TB.AppendText(groups.ServiceName.Name + Environment.NewLine);

                foreach (var prior in groups.Priotities)
                {
                    _LinQ_TB.AppendText("   -   Приоритет " + (prior.PriorityCar == 1 ? "'Да'" : "'Нет'") + $": {prior.Sum}" + Environment.NewLine);
                }
            }
        }
    }
}
