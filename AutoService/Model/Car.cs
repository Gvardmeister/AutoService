using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model
{
    public class Car
    {
        private static int Counter; // Счетчик созданных автомобилей
        private int _ID; // Уникальный индетификатор
        private List<CarService> _NeedService; // Список сервисов необходимых автомобилю
        private int _CurrentService; // Текущий сервис необходимый автомобилю
        private int _TimeProcessing; // Оставшееся время выполениня сервиса после каждого шага
        private int _Time; // Время выполения операции
        private bool _PriorityCar; // Приоритетность автомобиля

        // Основной конструктор класса
        public Car(List<CarService> Needservice, int TimeProcessing, int Time, int CurrentService, bool PriorityCar)
        {
            _ID = ++Counter;

            _PriorityCar = PriorityCar;

            if (Needservice == null)
            {
                throw new Exception("Параметр сервиса не может содержать null");
            }

            for (int i = 0; i < Needservice.Count; i++)
            {
                if (Needservice[i].Index < 0 && Needservice[i].Index > Services.Types.Length - 1)
                {
                    throw new Exception("Параметр сервиса должен находиться в диапозоне от 0 до 3");
                }
            }

            _NeedService = Needservice;

            // -1 - не используется ни в одном сервисе
            _CurrentService = CurrentService;

            if (TimeProcessing >= 0)
            {
                _TimeProcessing = TimeProcessing;
                _Time = Time;
            }
            else
            {
                throw new Exception("Время не может быть отрицательным");
            }
        }

        // Конструктор по умолчанию для класса Car
        public Car() : this( new List<CarService> { new CarService()}, 1, 1, 0, false) { }

        // Метод для корректного отображения
        public override string ToString()
        {
            return $"Автомобиль {_ID} ";
        }

        // Индексатор для доступа к списку сервисов
        public CarService this[int index]
        {
            get
            {
                return _NeedService[index];
            }
            set
            {
                if (value.Index < 0 && value.Index > Services.Types.Length - 1)
                {
                    throw new Exception("Параметр сервиса должен находиться в диапозоне от 0 до 3");
                }

                _NeedService[index] = value;
            }
        }

        // Свойство для доступа к оставшемуся времени
        public int TimeProcessing
        {
            get
            {
                return _TimeProcessing;
            }
            set
            {
                if (value >= 0)
                {
                    _TimeProcessing = value;
                }
            }
        }

        // Свойство для доступа к общему времени 
        public int Time
        {
            get
            {
                return _Time;
            }

            set
            {
                if (value >= 0)
                {
                    _Time = value;
                }
            }
        }

        // Свойство для доступа к уникальному индитификатору
        public int ID
        {
            get
            {
                return _ID;
            }
        }

        // Метод для рассчета оставшегося времени выполнения сервиса
        public int SubstractTime(int time)
        {
            if (time <= _TimeProcessing)
            {
                _TimeProcessing -= time;
            }
            else
            {
                _TimeProcessing = 0;
            }

            return _TimeProcessing;
        }

        // Свойство для доступа к текущему сервису
        public int CurrentService
        {
            get
            {
                return _CurrentService;
            }
            set
            {
                _CurrentService = value;
            }
        }

        // Свойство для доступа приоритетности автомобиля
        public bool PriorityCar
        {
            get
            {
                return _PriorityCar;
            }
            set
            {
                _PriorityCar = value;
            }
        }

        // Метод для получения количества сервисов
        public int GetCountServices()
        {
            return _NeedService.Count;
        }

        // Метод для удаления сервиса по индексу из списка
        public void RemoveServiceByIndex(int index)
        {
            _NeedService.RemoveAt(index);
        }

        // Метод для получения списка необходимых сервисов
        public List<CarService> GetNeedService()
        {
            return _NeedService;
        }
    }
}
