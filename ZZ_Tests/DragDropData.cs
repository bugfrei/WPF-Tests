using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZZ_Tests
{
    public class DragDropData 
    {
        public DragDropRow DDRow  {get;}
        public int Row { get; }

        public DragDropData(DragDropRow DDRow, int row)
        {
            this.DDRow = DDRow;
            this.Row = row;
        }

    }
}
