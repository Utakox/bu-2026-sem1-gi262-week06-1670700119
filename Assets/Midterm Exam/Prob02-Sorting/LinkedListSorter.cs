using System.Collections.Generic;
using UnityEngine;

namespace MidtermExam.Prob02
{
    public class LinkedListSorter
    {
        /// <summary>
        /// เรียงลำดับตัวเลขใน LinkedList จากน้อยไปมาก (Ascending Order)
        /// </summary>
        /// <param name="list">LinkedList ของตัวเลข integer</param>
        /// <returns>LinkedList ที่ได้รับการเรียงลำดับจากน้อยไปมากแล้ว</returns>
       public LinkedList<int> SortAscending(LinkedList<int> list)
        {
            // ช็คลิสต์ว่างหรือมีโหนด <= 1
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            bool swapped;
            do
            {
                swapped = false;
                LinkedListNode<int> current = list.First;

                while (current != null && current.Next != null)
                {
                    // ถ้าน้อยไปมาก: ตัวหน้า > ตัวหลัง ให้สลับ
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;

                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);

            return list;
        }

        public LinkedList<int> SortDescending(LinkedList<int> list)
        {
            // Edge Cases: เช็คลิสต์ว่างหรือมีโหนด <= 1
            if (list == null || list.Count <= 1)
            {
                return list;
            }

            bool swapped;
            do
            {
                swapped = false;
                LinkedListNode<int> current = list.First;

                while (current != null && current.Next != null)
                {
                    // มากไปน้อย --> ตัวหน้า < ตัวหลัง ให้สลับ
                    if (current.Value < current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;

                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);

            return list;
        }
    }
}
