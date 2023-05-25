﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasaMendes
{
    public partial class JmsDecimalTextboxAR : TextBox
    {
        public decimal ValorDecimal { get; set; }

        protected override void OnCreateControl()
        {
            if (string.IsNullOrEmpty(this.Text))
                this.Text = "0,00";
            this.TextAlign = HorizontalAlignment.Right;
            this.BorderStyle = BorderStyle.FixedSingle;
            base.OnCreateControl();
        }

        protected override void OnEnter(EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                if (this.Text != "0,00")
                {
                    this.SelectAll();
                }
                else
                {
                    ValorDecimal = 0;
                    this.Clear();
                    this.Focus();
                }
            }
            this.BackColor = Color.LightGreen;
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.Text))
            {
                ValorDecimal = Convert.ToDecimal(this.Text);
                this.Text = ValorDecimal.ToString("N2");
            }
            else
                this.Text = "0,00";

            this.BackColor = Color.White;
            base.OnLeave(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == "\b" || e.KeyChar.ToString() == "," || e.KeyChar.ToString() == "-")
                base.OnKeyPress(e);
            else
                e.Handled = true;

            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{Tab}");
            }
            base.OnKeyDown(e);
        }

    }
}
