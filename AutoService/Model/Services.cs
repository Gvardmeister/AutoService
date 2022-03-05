using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Model
{
   public static class Services
   {
       // Статический класс, хранящий типы сервисов
        public static readonly Service[] Types =
        {
            new Service("Мойка"),
            new Service("Замена жидкости"),
            new Service("Балансировка колес"),
            new Service("Проверка электроники"),
        };
   }
}
