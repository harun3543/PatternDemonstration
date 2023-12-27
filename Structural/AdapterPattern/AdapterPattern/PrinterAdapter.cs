using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class PrinterAdapter : IMachine
    {
        private readonly OldPrinter _printer;
        public PrinterAdapter(OldPrinter printer)
        {
            _printer = printer;
        }
        public void Start()
        {
            _printer.PowerOn();
        }

        public void Stop()
        {
            _printer.PowerOff();
        }
    }
}