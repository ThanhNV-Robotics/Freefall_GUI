using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
namespace FreeFall_GUI
{
    public partial class _2ndDataGraph : Form
    {
        bool ViewMode;
        public _2ndDataGraph()
        {
            InitializeComponent();
        }
        public void SetViewMode (bool Mode)
        {
            ViewMode = Mode;
        }
        public void ReSetGraph()
        {
            DataGraph.GraphPane.CurveList.Clear(); // Xoa do thi

            //GraphInit(); // Reinitialize the Graph

            DataGraph.GraphPane.XAxis.Scale.Max = 10;
            DataGraph.GraphPane.XAxis.Scale.Min = 0;
            DataGraph.GraphPane.YAxis.Scale.Max = 100;
            DataGraph.GraphPane.YAxis.Scale.Min = -100;

            DataGraph.GraphPane.Y2Axis.Scale.Max = 10;
            DataGraph.GraphPane.Y2Axis.Scale.Min = -10;

            DataGraph.GraphPane.IsAlignGrids = true;

            RollingPointPairList GyroXList = new RollingPointPairList(60000);
            LineItem GyroXCurve = DataGraph.GraphPane.AddCurve("GyroX", GyroXList, Color.Brown, SymbolType.None);
            GyroXCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList GyroYList = new RollingPointPairList(60000);
            LineItem GyroYCurve = DataGraph.GraphPane.AddCurve("GyroY", GyroYList, Color.Black, SymbolType.None);
            GyroYCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList GyroZList = new RollingPointPairList(60000);
            LineItem GyroZCurve = DataGraph.GraphPane.AddCurve("GyroZ", GyroZList, Color.Blue, SymbolType.None);
            GyroZCurve.Line.Width = (float)3; // Set LineWidth


            RollingPointPairList DistanceList = new RollingPointPairList(60000);
            LineItem DistanceCurve = DataGraph.GraphPane.AddCurve("Position", DistanceList, Color.Lime, SymbolType.None);
            DistanceCurve.Line.Width = (float)3; // Set LineWidth

            DistanceCurve.IsY2Axis = true;

            DataGraph.AxisChange();
            DataGraph.Invalidate();
        }
        private void _2ndDataGraph_Load(object sender, EventArgs e)
        {
            //DataGraph = new ZedGraph.ZedGraphControl();
            GraphInit();
        } 
        
        private void GraphInit()
        {
            GraphPane myPane = DataGraph.GraphPane;
            myPane.Title.Text = " Gyro & Distance";
            myPane.XAxis.Title.Text = "time (s)";
            myPane.YAxis.Title.Text = "Gyro(rad/s)";
            myPane.YAxis.Scale.FontSpec.FontColor = Color.Red;
            myPane.YAxis.Title.FontSpec.FontColor = Color.Red;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 10;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;

            myPane.YAxis.Scale.Min = -10;
            myPane.YAxis.Scale.Max = 10;


            myPane.Y2Axis.Title.Text = "Distance (mm)";
            myPane.Y2Axis.Scale.Min = -100;
            myPane.Y2Axis.Scale.Max = 100;
            myPane.Y2Axis.Scale.MinorStep = 5;
            myPane.Y2Axis.Scale.FontSpec.FontColor = Color.Blue;
            myPane.Y2Axis.Title.FontSpec.FontColor = Color.Blue;
            myPane.Y2Axis.IsVisible = true;

            myPane.IsAlignGrids = true;
                        

            RollingPointPairList GyroXList = new RollingPointPairList(60000);
            LineItem GyroXCurve = myPane.AddCurve("GyroX", GyroXList, Color.Brown, SymbolType.None);
            GyroXCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList GyroYList = new RollingPointPairList(60000);
            LineItem GyroYCurve = myPane.AddCurve("GyroY", GyroYList, Color.Black, SymbolType.None);
            GyroYCurve.Line.Width = (float)1.5; // Set LineWidth

            RollingPointPairList GyroZList = new RollingPointPairList(60000);
            LineItem GyroZCurve = myPane.AddCurve("GyroZ", GyroZList, Color.Blue, SymbolType.None);
            GyroZCurve.Line.Width = (float)3; // Set LineWidth
            

            RollingPointPairList DistanceList = new RollingPointPairList(60000);
            LineItem DistanceCurve = myPane.AddCurve("Position", DistanceList, Color.Lime, SymbolType.None);
            DistanceCurve.Line.Width = (float)3; // Set LineWidth

            GyroXCurve.IsY2Axis = true;
            GyroYCurve.IsY2Axis = true;
            GyroZCurve.IsY2Axis = true;
            DistanceCurve.IsY2Axis = true;            

            myPane.AxisChange();
        }

        public void DrawAllData(double time, double _GyroX, double _GyroY, double _GyroZ, double Position)
        {
            if (DataGraph.GraphPane.CurveList.Count <= 0) // neu ko co duong du lieu dc khoi tao
            {
                return; // Thoat ham
            }


            // X axis
            LineItem GyroXCurve = DataGraph.GraphPane.CurveList[0] as LineItem;
            if (GyroXCurve == null) return;
            IPointListEdit GyroXList = GyroXCurve.Points as IPointListEdit;
            if (GyroXList == null) return;
            //time = (Environment.TickCount - TickStart) / 1000.0;
            GyroXCurve.IsY2Axis = true;
            GyroXList.Add(time, _GyroX);

            // Y axis
            LineItem GyroYCurve = DataGraph.GraphPane.CurveList[1] as LineItem;
            if (GyroYCurve == null) return;
            IPointListEdit GyroYList = GyroYCurve.Points as IPointListEdit;
            if (GyroYList == null) return;
            //time = (Environment.TickCount - TickStart) / 1000.0;
            GyroYCurve.IsY2Axis = true;
            GyroYList.Add(time, _GyroY);

            // Z axis
            LineItem GyroZCurve = DataGraph.GraphPane.CurveList[2] as LineItem;
            if (GyroZCurve == null) return;
            IPointListEdit GyroZList = GyroZCurve.Points as IPointListEdit;
            if (GyroZList == null) return;
            //time = (Environment.TickCount - TickStart) / 1000.0;
            GyroZCurve.IsY2Axis = true;
            GyroZList.Add(time, _GyroZ);


            LineItem PositionCurve = DataGraph.GraphPane.CurveList[3] as LineItem;
            if (PositionCurve == null) return;
            IPointListEdit PositionList = PositionCurve.Points as IPointListEdit;
            if (PositionList == null) return;
            //time = (Environment.TickCount - TickStart) / 1000.0;
            //PositionCurve.IsY2Axis = true;
            PositionList.Add(time, Position);



            Scale xScale = DataGraph.GraphPane.XAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = time + xScale.MajorStep;
                xScale.Min = time - xScale.MajorStep;
                //if (ViewMode) // SCROLL view Mode
                //{
                //    xScale.Max = time + xScale.MajorStep;
                //    xScale.Min = time - xScale.MajorStep;
                //}
                //else // COMPACR view Mode
                //{
                //    xScale.Max = time + xScale.MajorStep;
                //    xScale.Min = 0;
                //}
            }
            Scale Y1Scale = DataGraph.GraphPane.YAxis.Scale;
            Scale Y2Scale = DataGraph.GraphPane.Y2Axis.Scale;
            

            if (_GyroX > Y1Scale.Max || _GyroY > Y1Scale.Max || _GyroZ > Y1Scale.Max)
            {
                Y2Scale.Max = _GyroX + 2 * Y2Scale.MajorStep;
            }
            if (_GyroZ < Y2Scale.Min)
            {
                Y2Scale.Min = _GyroZ - 2 * Y2Scale.MajorStep;
            }
            DataGraph.GraphPane.IsAlignGrids = true;
            DataGraph.AxisChange();
            DataGraph.Invalidate();
        }
    }
}
