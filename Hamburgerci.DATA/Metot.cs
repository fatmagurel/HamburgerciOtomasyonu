using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgerci.DATA
{
    public static class Metot
    {
        //formların kontrolleri gönderilerek temizlenecek.
        //eğer gönderilen kontrol bir groupbox veya flp ise recursive olarak tekrar ilgili metot çağırılacak.
        //uzun uzun her bir controlü değerlendirip yap.


        public static void Temizle(Control.ControlCollection koleksiyon)
        {
            foreach (Control item in koleksiyon)
            {
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
                else if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Text = "Küçük";
                }
                else if (item is CheckBox)
                {
                    ((CheckBox)item).Checked = false;
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).Items.Clear();
                }
                else if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 0;
                }
                else if (item is GroupBox)
                {
                    Temizle(((GroupBox)item).Controls);
                }
                else if (item is FlowLayoutPanel)
                {
                    Temizle(((FlowLayoutPanel)item).Controls);
                }
            }
        }


        //public static void Temizle(GroupBox grp)
        //{
        //    foreach (Control item in grp.Controls)
        //    {
        //        if (item is TextBox) item.Text = "";
        //        else if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
        //    }
        //}

        //public static void Temizle(Form form)
        //{
        //    foreach (Control item in form.Controls)
        //    {
        //        if (item is TextBox) item.Text = "";
        //        else if (item is ComboBox) ((ComboBox)item).SelectedIndex = 0;
        //        else if (item is RadioButton) ((RadioButton)item).Text = "Küçük";
        //        else if (item is NumericUpDown) ((NumericUpDown)item).Value = 0;
        //        else if (item is ListBox) ((ListBox)item).Items.Clear();
        //    }
        //}
        //public static void Temizle(FlowLayoutPanel flp)
        //{
        //    foreach (Control item in flp.Controls)
        //    {
        //        if (item is CheckBox)
        //            ((CheckBox)item).Checked = false;
        //    }
        //}
    }
}
