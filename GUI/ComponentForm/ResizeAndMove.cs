using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI.ComponentForm
{
    public class ResizeAndMove
    {
        #region Properties
        //Location của event move được bắt đầu từ (0,0) theo vị trí của Control move không phải theo tọa độ trên Screen
        public enum ResizeType { None, Left, TopLeft, Top, TopRight, Right, BotRight, Bot, BotLeft }
        private ResizeType rsty = ResizeType.None; //Kiểu Resize form
        private bool mouseDownResize = false;
        private bool mouseDownMove = false;
        private Point locationMouseDown; //Vị trí chuột khi click Resize
        #endregion

        #region Create
        public ResizeAndMove(Form frm, Control[] ctrlMoveForms, bool Resize)
        {
            #region Resize
            if (Resize)
            {
                frm.MouseLeave += delegate (object sender, EventArgs e)
                {
                    frm.Cursor = Cursors.Default;
                    rsty = ResizeType.None;
                };

                frm.MouseDown += delegate (object sender, MouseEventArgs e)
                {
                    mouseDownResize = true;
                    locationMouseDown = e.Location;
                };

                frm.MouseUp += delegate (object sender, MouseEventArgs e)
                {
                    mouseDownResize = false;
                    frm.Cursor = Cursors.Default;
                };

                frm.MouseMove += delegate (object sender, MouseEventArgs e)
                {
                    if (mouseDownResize)
                    {
                        switch (rsty)
                        {
                            case ResizeType.Left:
                                if (frm.Width + (locationMouseDown.X - e.X) > frm.MinimumSize.Width)
                                {
                                    frm.Width += locationMouseDown.X - e.X;
                                    frm.Left -= locationMouseDown.X - e.X;
                                }
                                break;
                            case ResizeType.TopLeft:
                                //TL
                                if ((frm.Width + (locationMouseDown.X - e.X) > frm.MinimumSize.Width) && (frm.Height + (locationMouseDown.Y - e.Y) > frm.MinimumSize.Height))
                                {
                                    frm.Location = new Point(frm.Left - (locationMouseDown.X - e.X), frm.Top - (locationMouseDown.Y - e.Y));
                                    frm.Width += locationMouseDown.X - e.X;
                                    frm.Height += locationMouseDown.Y - e.Y;
                                }
                                //L
                                else if (frm.Width + (locationMouseDown.X - e.X) > frm.MinimumSize.Width)
                                {
                                    frm.Width += locationMouseDown.X - e.X;
                                    frm.Left -= locationMouseDown.X - e.X;
                                }
                                //T
                                else if (frm.Height + (locationMouseDown.Y - e.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Top -= locationMouseDown.Y - e.Y;
                                    frm.Height += locationMouseDown.Y - e.Y;
                                }
                                break;
                            case ResizeType.Top:
                                if (frm.Height + (locationMouseDown.Y - e.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Top -= locationMouseDown.Y - e.Y;
                                    frm.Height += locationMouseDown.Y - e.Y;
                                }
                                break;
                            case ResizeType.TopRight:
                                //TR
                                if (frm.Height + (locationMouseDown.Y - e.Y) > frm.MinimumSize.Height && frm.Width + (e.X - locationMouseDown.X) > frm.MinimumSize.Width)
                                {
                                    frm.Top -= locationMouseDown.Y - e.Y;
                                    frm.Height += locationMouseDown.Y - e.Y;
                                    frm.Width += e.X - locationMouseDown.X;
                                    locationMouseDown.X = e.X;
                                }
                                //T
                                else if (frm.Height + (locationMouseDown.Y - e.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Top -= locationMouseDown.Y - e.Y;
                                    frm.Height += locationMouseDown.Y - e.Y;
                                }
                                //R
                                else if (frm.Width + (e.X - locationMouseDown.X) > frm.MinimumSize.Width)
                                {
                                    frm.Width += e.X - locationMouseDown.X;
                                    locationMouseDown.X = e.X;
                                }
                                break;
                            case ResizeType.Right:
                                if (frm.Width + (e.X - locationMouseDown.X) > frm.MinimumSize.Width)
                                {
                                    frm.Width += e.X - locationMouseDown.X;
                                    locationMouseDown.X = e.X;
                                }
                                break;
                            case ResizeType.BotRight:
                                //BR
                                if (frm.Width + (e.X - locationMouseDown.X) > frm.MinimumSize.Width && frm.Height + (e.Y - locationMouseDown.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Width += e.X - locationMouseDown.X;
                                    frm.Height += e.Y - locationMouseDown.Y;
                                    locationMouseDown = e.Location;
                                }
                                //R
                                else if (frm.Width + (e.X - locationMouseDown.X) > frm.MinimumSize.Width)
                                {
                                    frm.Width += e.X - locationMouseDown.X;
                                    locationMouseDown.X = e.X;
                                }
                                //B
                                else if (frm.Height + (e.Y - locationMouseDown.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Height += e.Y - locationMouseDown.Y;
                                    locationMouseDown.Y = e.Y;
                                }
                                break;
                            case ResizeType.Bot:
                                if (frm.Height + (e.Y - locationMouseDown.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Height += e.Y - locationMouseDown.Y;
                                    locationMouseDown.Y = e.Y;
                                }
                                break;
                            case ResizeType.BotLeft:
                                //BL
                                if (frm.Width + (locationMouseDown.X - e.X) > frm.MinimumSize.Width && frm.Height + (e.Y - locationMouseDown.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Left -= locationMouseDown.X - e.X;
                                    frm.Width += locationMouseDown.X - e.X;
                                    frm.Height += e.Y - locationMouseDown.Y;
                                    locationMouseDown.Y = e.Y;
                                }
                                //B
                                else if (frm.Height + (e.Y - locationMouseDown.Y) > frm.MinimumSize.Height)
                                {
                                    frm.Height += e.Y - locationMouseDown.Y;
                                    locationMouseDown.Y = e.Y;
                                }
                                //L
                                else if (frm.Width + (locationMouseDown.X - e.X) > frm.MinimumSize.Width)
                                {
                                    frm.Width += locationMouseDown.X - e.X;
                                    frm.Left -= locationMouseDown.X - e.X;
                                }
                                break;
                        }
                    }
                    else
                    {
                        if (e.X > 0 && e.X < frm.Width - 1 && e.Y > 0 && e.Y < frm.Height - 1)
                        {
                            frm.Cursor = Cursors.Default;
                            rsty = ResizeType.None;
                        }
                        else if (e.X == 0 && e.Y >= 10 && e.Y < frm.Height - 10)
                        {
                            frm.Cursor = Cursors.SizeWE;
                            rsty = ResizeType.Left;
                        }
                        else if ((e.X == 0 && e.Y < 10) || (e.Y == 0 && e.X < 10))
                        {
                            frm.Cursor = Cursors.SizeNWSE;
                            rsty = ResizeType.TopLeft;
                        }
                        else if (e.Y == 0 && e.X >= 10 && e.X < frm.Width - 10)
                        {
                            frm.Cursor = Cursors.SizeNS;
                            rsty = ResizeType.Top;
                        }
                        else if ((e.Y == 0 && e.X >= frm.Width - 10) || (e.X == frm.Width - 1 && e.Y < 10))
                        {
                            frm.Cursor = Cursors.SizeNESW;
                            rsty = ResizeType.TopRight;
                        }
                        else if (e.X == frm.Width - 1 && e.Y >= 10 && e.Y < frm.Height - 10)
                        {
                            frm.Cursor = Cursors.SizeWE;
                            rsty = ResizeType.Right;
                        }
                        else if ((e.X == frm.Width - 1 && e.Y >= frm.Height - 10) || (e.Y == frm.Height - 1 && e.X >= frm.Width - 10))
                        {
                            frm.Cursor = Cursors.SizeNWSE;
                            rsty = ResizeType.BotRight;
                        }
                        else if (e.Y == frm.Height - 1 && e.X >= 10 && e.X < frm.Width - 10)
                        {
                            frm.Cursor = Cursors.SizeNS;
                            rsty = ResizeType.Bot;
                        }
                        else if ((e.Y == frm.Height - 1 && e.X < 10) || (e.X == 0 && e.Y >= frm.Height - 10))
                        {
                            frm.Cursor = Cursors.SizeNESW;
                            rsty = ResizeType.BotLeft;
                        }
                    }
                };
            }
            #endregion

            #region Move
            foreach (Control ctrlMoveForm in ctrlMoveForms)
                if (ctrlMoveForm != null)
                {
                    ctrlMoveForm.MouseDown += delegate (object sender, MouseEventArgs e)
                    {
                        //MessageBox.Show("Test");
                        mouseDownMove = true;
                        locationMouseDown = e.Location;
                    };

                    ctrlMoveForm.MouseUp += delegate (object sender, MouseEventArgs e)
                    {
                        mouseDownMove = false;
                    };

                    ctrlMoveForm.MouseMove += delegate (object sender, MouseEventArgs e)
                    {
                        //MessageBox.Show("Test");
                        if (mouseDownMove)
                        {
                            frm.Top += e.Y - locationMouseDown.Y;
                            frm.Left += e.X - locationMouseDown.X;
                        }
                    };
                }
            #endregion
        }
        #endregion
    }
}
