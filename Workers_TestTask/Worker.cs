using System;
using System.Collections.Generic;
using System.Text;

namespace Workers_TestTask
{
    // Построить три класса(базовый и 2 потомка), описывающих некоторых
    // работников с почасовой оплатой(один из потомков) и фиксированной
    // оплатой(второй потомок). Описать в базовом классе абстрактный метод
    // для расчета среднемесячной заработной платы. Для «повременщиков» 
    // формула для расчета такова: «среднемесячная заработная 
    // плата = 20.8 * 8 * почасовую ставку», для работников с фиксированной 
    // оплатой «среднемесячная заработная плата = фиксированной месячной оплате».
    
    abstract class Worker : IComparable<Worker>
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public double Salary { protected set; get; }

        public abstract void СalculateSalary(double salary);
        
        public int CompareTo(Worker worker)
        {
            if (Salary > worker.Salary)
            {
                return 1;
            }
            else if (Salary == worker.Salary)
            {                
                if (Name.CompareTo(worker.Name) < 0)
                {
                    return 1;
                }
                else if (Name.CompareTo(worker.Name) == 0)
                {
                    return 0;
                }                
            }

            return -1;
        }
    }
}
