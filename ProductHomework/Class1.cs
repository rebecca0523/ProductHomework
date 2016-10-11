using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProductHomework
{ /// <summary>
/// 1.summary mark first
/// 2.create Git success
/// 3.update Git Success
/// 3.1 file commit 
/// 3.1 Team Explorer
/// 3.2 Sync
/// 3.3 Push 
/// 4. Ctrl + K,Ctrl + C 區塊mark 
/// 5.支援泛型的 production code
/// 6.nuGet下載 ExpectedObjects
/// 7.Ctrl + K ,Ctrol +D 排版
/// 8.add comment commit 
/// 9.去整行空白, 
/// </summary>

        //泛型1,回傳int (傳入泛型2)
        //泛型2 回傳<T> (傳入資料源,彈性組數,欄位名稱)
        public class CollectionHelper
        {
            public IEnumerable<int> GetGroupSumByField<T>(IEnumerable<T> dataSource, int countInGroup, string fieldName)
            {
                return dataSource.Select((value, index) => new { GroupNum = index / countInGroup, value })
                    .GroupBy(group => group.GroupNum)
                    .Select(group => group.Select(g => Convert.ToInt32(g.value.
                                                                         GetType().
                                                                         GetProperty(fieldName).
                                                                         GetValue(g.value, null))
                                                  )
                                           .Sum())
                    .ToArray();
            }
        }

    
}
