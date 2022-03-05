using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoService.Model
{
    public class FactService
    {
        private static int Counter; // Счетчик созданных объектов
        private int _ID; // Уникальный индетификатор
        private int _ServiceType; // Тип сервиса (какой из сервисов выполняется)
        private int _TimeService; // Время выполнения операции сервисом
        private int _Priority; // Приоритетность автомобиля

        // Констуктор класса
        public FactService(int ServiceType, int TimeService, int Priority)
        {
            try
            {
                // Условие проверки сервиса и времени: какому сервису и за какое время необходимо выполниться
                if (ServiceType == 0)
                {
                    if (TimeService < 1 && TimeService > 5)
                    {
                        throw new Exception("Время помывки выходит за границу");
                    }
                }
                else
                {
                    if (TimeService < 3 && TimeService > 6)
                    {
                        throw new Exception("Время работы других операций выходит за границу");
                    }
                }

                _ID = ++Counter;

                _ServiceType = ServiceType;
                _TimeService = TimeService;

                // Условие проверки приоритетности автомобиля: 1 - приоритетный, 0 - не приоритетный
                if (Priority == 1 || Priority == 0)
                {
                    _Priority = Priority;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Параметры записи Log-файла заданы неправильно : " + ex.Message);
            }
        }

        // Конструктор по умолчанию для класса FactService
        public FactService() : this(0, 1, 1) {}

        // Метод для корректного отображения
        public override string ToString()
        {
            return $"{_ID}: услуга '{Services.Types[_ServiceType].Name}', время услуги '{_TimeService}', " +
                $"приоритет" + (_Priority == 1 ? "Да" : "Нет");
        }

        // Свойство для доступа к уникальному индетификатору
        public int ID
        {
            get
            {
                return _ID;
            }
        }

        // Свойство для доступа ко времени выполнения операции
        public int TimeService
        {
            get
            {
                return _TimeService;
            }
        }

        // Свойство для доступа к типу сервиса
        public int ServiceType
        {
            get
            {
                return _ServiceType;
            }
        }

        // Свойство для доступа к приоритетности
        public int Priority
        {
            get
            {
                return _Priority;
            }
        }

        // Метод для получения типа сервиса и времени его выполнения
        // Метод требуется только для проверки уже существубщего объекта, если потребуется его изменить в дальнейшем
        public void SetTypeServiceAndSetTimeService(int ServiceType, int TimeService)
        {
            // Условие проверки корректности сервиса и времени
            if (ServiceType == 0)
            {
                if (TimeService < 1 && TimeService > 5)
                {
                    throw new Exception("Время помывки выходит за границу");
                }
            }
            else
            {
                if (TimeService < 3 && TimeService > 6)
                {
                    throw new Exception("Время работы других операций выходит за границу");
                }
            }

            _ServiceType = ServiceType;
            _TimeService = TimeService;
        }
    }
}
