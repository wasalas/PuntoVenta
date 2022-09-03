using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public class Metodos
    {
        public static void Formato_dgv(DataGridView parm_dgv, int parm_color)
        {
            // Método para dar formato al DataGridView
            // recibimos dos paramateros : uno tipo DataGrid y otro int para la selección del color.

            //Font para las filas
            //parm_dgv.RowsDefaultCellStyle.Font = new Font("Open Sans", 10f, FontStyle.Regular);
            parm_dgv.RowsDefaultCellStyle.Font = new Font("Verdana", 9f, FontStyle.Regular);
            parm_dgv.AlternatingRowsDefaultCellStyle.Font = new Font("Verdana", 9f, FontStyle.Regular);

            //Font para las columnas
            //parm_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Lato", 12f, FontStyle.Bold);
            parm_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 9f, FontStyle.Bold);

            //Ancho de columnas
            //parm_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Alto de las filas
            //parm_dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            //No se agrege columnas automaticamente
            parm_dgv.AutoGenerateColumns = false;

            //Quitamos el borde
            parm_dgv.BorderStyle = BorderStyle.None;
            parm_dgv.EnableHeadersVisualStyles = false;
            parm_dgv.RowHeadersVisible = false;
            parm_dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            
            //Color de letra de las columnas
            parm_dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            switch (parm_color)
            {
                case 1:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(79, 129, 189);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(184, 204, 228);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(143, 191, 231);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(220, 230, 241);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(119, 174, 223);
                    break;
                case 2:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 0);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(166, 166, 166);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 149, 183);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(217, 217, 217);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 183, 216);
                    break;
                case 3:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(192, 80, 77);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(230, 184, 183);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(149, 161, 194);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(242, 220, 219);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(157, 185, 217);
                    break;
                case 4:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(155, 187, 89);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(216, 228, 188);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(140, 190, 197);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(235, 241, 222);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(152, 198, 219);
                    break;
                case 5:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(128, 100, 162);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 192, 218);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(132, 166, 216);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(228, 223, 236);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(148, 186, 228);
                    break;
                case 6:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(75, 172, 198);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(183, 222, 232);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(118, 186, 226);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(218, 238, 243);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(141, 196, 233);
                    break;
                case 7:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(247, 150, 70);
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(252, 213, 180);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 180, 192);
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 233, 217);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(164, 193, 216);
                    break;
                case 10:
                    //Columna
                    parm_dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(100, 111, 212);
                    
                    //Fila
                    parm_dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(219, 223, 253);
                    parm_dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromName("Highlight");
                    
                    //Fila alternativa
                    parm_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(155, 163, 235);
                    parm_dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromName("Highlight");
                    break;
            }
        }

        
    }
}
