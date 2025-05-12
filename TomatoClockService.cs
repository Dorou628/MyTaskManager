using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTaskManager;
namespace TomatoClock
{
    public class TomatoClockService : ITomatoService
    {
        private Tomato _tomatoForm;
        public void ShowTomatoClock()
        {
            if (_tomatoForm == null||_tomatoForm.IsDisposed)
            {
                _tomatoForm = new Tomato();
                _tomatoForm.Start();
            }
            _tomatoForm.Show();
        }
    }

}
