using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_距離計算票價
{
    public class Ticket
    {
        /// <summary>
        /// 距離。
        /// </summary>
        public double Distance { get; }

        /// <summary>
        /// 票價，每公里10元，超過100公里每公里8元。
        /// </summary>
        public double Price
        {
            get
            {
                if (Distance <= 100)
                {
                    return Distance * 10;
                }
                else
                {
                    return (Distance-100) * 8 + 1000;
                }
            }
        }

        /// <summary>
        /// 構造函數，若距離為負數則為0。
        /// </summary>
        /// <param name="distance">距離</param>
        public Ticket(double distance)
        {
            if (distance < 0)
            {
                distance = 0;
            }
            this.Distance = distance;
        }

        /// <summary>
        /// 輸出票價
        /// </summary>
        /// <returns>票價訊息</returns>
        public string GetPrice() => $"{this.Distance}公里的票價為{this.Price}";
        

    }
}
