using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proekt_VP_Sorting {
    public partial class AddArray : Form {

        public Random random { get; set; }
        public int[] array { get; set; }

        public int size { get; set; }

        public int delay { get; set; }
        public AddArray() {
            InitializeComponent();
            random = new Random();
            delay = 1;

        }

        private void AddArray_Validating(object sender, CancelEventArgs e) {

            // TODO Check if elements input is the same as size !!!!!!!!!!!!!!

            if (radioCustom.Checked) {
                if (tbArray.Text.Count() == 0) {
                    errorProvider1.SetError(tbArray, "Array must not be empty!");
                }
                else {
                    errorProvider1.SetError(tbArray, null);
                }
            }

            if (nudSize.Value == 0) {
                errorProvider1.SetError(nudSize, "Array size must not be 0");
            }
            else {
                errorProvider1.SetError(nudSize, null);
            }
        }

        private void tbDelay_TextChanged(object sender, EventArgs e) {
            delay = int.Parse(tbDelay.Text);
        }

        private void radioRandom_CheckedChanged(object sender, EventArgs e) {
            radioRandom.Checked = true;
            radioCustom.Checked = false;

        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e) {
            radioCustom.Checked = true;
            radioRandom.Checked = false;
        }

        private void btnSort_Click(object sender, EventArgs e) {
            if (radioCustom.Checked) {
                // TODO !!!!!!!
                // 1 2 3 4 5
                // 1,2,3,4,5
                // 1, 2, 3, 4, 5

                string[] arr = tbArray.Text.Split(' ');
                size = arr.Length;
                array = new int[size];
                for (int i = 0; i < arr.Length; i++) {
                    array[i] = int.Parse(arr[i]);
                }
            }
            else {
                size = (int)nudSize.Value;
                array = new int[size];
                for (int i = 0; i < size; i++) {
                    array[i] = random.Next(1, 99);
                }
            }
            
        }
    }
}
