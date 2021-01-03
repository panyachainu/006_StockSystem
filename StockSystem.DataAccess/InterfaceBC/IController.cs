using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockSystem.DataAccess
{
    public interface IController<T> : IDisposable where T : class
    {
        void Insert(T Items);
        void Update(T Items);
        void Delete(T Items);
        /// <summary>
        /// ค้นหาข้อมูลตาม Primary Key
        /// </summary>
        /// <param name="Keys">เฉพาะ PK ต้องใส่ให้ครบ</param>
        /// <returns></returns>
        T GetFind(params object[] Keys);
        int SaveChanges();
        /// <summary>
        /// โหลดข้อมูลทั้งหมดของ Table โดยการ Where จะใส่ค่าที่ Object แล้วไป Implement Code ข้างใน ถ้าไม่มีให้ใส่ค่า NULL
        /// </summary>
        /// <param name="para1">ค่า where [1]</param>
        /// <param name="para2">ค่า where [2]</param>
        /// <param name="para3">ค่า where [3]</param>
        /// <param name="para4">ค่า where [4]</param>
        /// <param name="para5">ค่า where [5]</param>
        /// <returns></returns>
        IEnumerable<T> LoadAll(object para1, object para2, object para3, object para4, object para5);
        /// <summary>
        /// เก็บ Log ของ Linq ว่าทำอะไรบ้าง โดยดู จาก Debug จากหน้า Output
        /// </summary>
        /// <param name="LogDb"> Debug.Print("ชื่อ Class : {0}", LogDb);</param>
        void LogDB(string LogDb);
        string Name(string CodeID);
    }
}
