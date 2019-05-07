using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbryoExpress.UI.Report
{
    public class ReportManager
    {
        private Color _tableHeadBackColor;
        public Color TableHeadBackColor
        {
            get { return this._tableHeadBackColor; }
        }

        private static ReportManager _manager;

        public static int TableRowHeight = 22;

        public static int GroupSpace = 30;
        public static int ItemSpace = 10;
        public static int SpiltTableSpace = 2;

        private Font _reportGroupFont;
        public Font ReportGroupFont
        {
            get { return this._reportGroupFont; }
        }

        private Font _reportNormalFont;
        public Font ReportNormalFont
        {
            get { return this._reportNormalFont; }
        }

        private bool _landscape;
        public bool Landscape
        {
            get { return this._landscape; }
            set { this._landscape = value; }
        }

        private PaperKind _paperKind;
        public PaperKind PaperKind
        {
            get { return this._paperKind; }
            set { this._paperKind = value; }
        }

        private int _marginLeft;
        public int MarginLeft
        {
            get { return this._marginLeft; }
            set { this._marginLeft = value; }
        }

        private int _marginRight;

        public int MarginRight
        {
            get { return this._marginRight; }
            set { this._marginRight = value; }
        }

        private int _marginTop;
        public int MarginTop
        {
            get { return this._marginTop; }
            set { this._marginTop = value; }
        }

        private int _marginBottom;

        public int MarginBottom
        {
            get { return this._marginBottom; }
            set { this._marginBottom = value; }
        }

        private int tableWidth;

        public int TableWidth
        {
            get { return this.tableWidth; }
            set { this.tableWidth = value; }
        }

        public ReportManager()
        {
            this._tableHeadBackColor = Color.FromArgb(0xE7, 0xF0, 0xFA);
            this._reportNormalFont = new Font("Arial Unicode MS", 9.75F, System.Drawing.FontStyle.Regular);
            this._reportGroupFont = new Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold);

            Landscape = false;
            PaperKind = PaperKind.A4;
            MarginLeft = 50;
            MarginRight = 50;
            MarginBottom = 100;
            MarginTop = 100;
        }

        public static ReportManager Instance()
        {
            if (_manager == null) _manager = new ReportManager();
            return _manager;
        }

    }
}
