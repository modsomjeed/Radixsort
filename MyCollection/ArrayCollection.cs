using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCollection
{
    public class ArrayCollection : Collection
    {
        protected int SIZE;
        protected int cap;
        protected object[] data;
        public ArrayCollection(int cap)
        {
            data = new object[cap];
            this.cap = cap;
        }
        protected void ensureCapacity()// ตรวจสอบความจุของข้อมูลว่าสามารถเพิ่มข้อมูลเพิ่มได้ไหม
        {
            if (SIZE >= cap)
            {
                object[] temp = new object[SIZE * 2];//สร้าง[] tempที่มีขนาดใหญ่เป็นสองเท่าของsize
                for (int i = 0; i < SIZE; i++)
                    temp[i] = data[i];//ทำการคัดลอกข้อมูลจาก temp[i] = temp[i] โดยเอาแต่ละตำแหน่งมาเท่ากัน
                data = temp;//ให้ data = temp เพื่อเอา [] ใหม่มาเท่ากับ [] เดิม  
            }
            else if (data.Length > cap && data.Length > 2 * SIZE)
            {
                object[] temp = new object[data.Length / 2 + 1];
                for (int i = 0; i < SIZE; i++)
                    temp[i] = data[i];
                data = temp;
            }
        }
        public bool isEmpty()
        {
            return SIZE == 0;
        }
        public bool contains(object e)
        {
            return IndexOf(e) != -1;
        }
        public int size()
        {
            return SIZE;
        }
        public void add(object e)//เพิ่มข้อมูล
        {
            ensureCapacity();// ตรวจสอบความจุของข้อมูลว่าสามารถเพิ่มข้อมูลเพิ่มได้ไหม
            data[SIZE++] = e;//ให้ data=e และเพิ่มค่า size ขึ้น 1 ค่า
        }
        public int IndexOf(object e)
        {
            for (int i = 0; i < SIZE; i++)
                if (data[i].Equals(e))//ถ้า ข้อมูลตำแหน่งนั้น = e
                    return i;// return ค่าตำแหน่งของข้อมูล
            return -1; //ถ้าหาตำปหน่งข้อมูลไม่เจอ ให้ return -1
        }
        public void remove(object e)
        {
            int i = IndexOf(e);//ให้ i = ตำแหน่งของข้อมูล
            if (i != -1)//เมื่อ ตำแหน่งข้อมูลไม่เท่ากับ -1
            {
                data[i] = data[--SIZE];//ให้ตำแหน่งข้อมูลตัวสุดท้ายมาเป็นตำแหน่งรองสุดท้าย
                data[SIZE] = null;//ให้ตำแหน่งข้อมูลตัวสุดท้าย = null
                ensureCapacity();// ตรวจสอบความจุของข้อมูลว่าสามารถเพิ่มข้อมูลเพิ่มได้ไหม
            }
        }
    }
}

