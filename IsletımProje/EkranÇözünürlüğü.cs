using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsletımProje {
    enum DISP_CHANGE : int
{
    Successful = 0,
    Restart = 1,
    Failed = -1,
    BadMode = -2,
    NotUpdated = -3,
    BadFlags = -4,
    BadParam = -5,
    BadDualView = -6
}
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
struct DEVMODE
{
    public const int CCHDEVICENAME = 32;
    public const int CCHFORMNAME = 32;

    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
    [System.Runtime.InteropServices.FieldOffset(0)]
    public string dmDeviceName;
    [System.Runtime.InteropServices.FieldOffset(32)]
    public Int16 dmSpecVersion;
    [System.Runtime.InteropServices.FieldOffset(34)]
    public Int16 dmDriverVersion;
    [System.Runtime.InteropServices.FieldOffset(36)]
    public Int16 dmSize;
    [System.Runtime.InteropServices.FieldOffset(38)]
    public Int16 dmDriverExtra;
    [System.Runtime.InteropServices.FieldOffset(40)]
    public DM dmFields;

    [System.Runtime.InteropServices.FieldOffset(44)]
    Int16 dmOrientation;
    [System.Runtime.InteropServices.FieldOffset(46)]
    Int16 dmPaperSize;
    [System.Runtime.InteropServices.FieldOffset(48)]
    Int16 dmPaperLength;
    [System.Runtime.InteropServices.FieldOffset(50)]
    Int16 dmPaperWidth;
    [System.Runtime.InteropServices.FieldOffset(52)]
    Int16 dmScale;
    [System.Runtime.InteropServices.FieldOffset(54)]
    Int16 dmCopies;
    [System.Runtime.InteropServices.FieldOffset(56)]
    Int16 dmDefaultSource;
    [System.Runtime.InteropServices.FieldOffset(58)]
    Int16 dmPrintQuality;

    [System.Runtime.InteropServices.FieldOffset(44)]
    public POINTL dmPosition;
    [System.Runtime.InteropServices.FieldOffset(52)]
    public Int32 dmDisplayOrientation;
    [System.Runtime.InteropServices.FieldOffset(56)]
    public Int32 dmDisplayFixedOutput;

    [System.Runtime.InteropServices.FieldOffset(60)]
    public short dmColor; // See note below!
    [System.Runtime.InteropServices.FieldOffset(62)]
    public short dmDuplex; // See note below!
    [System.Runtime.InteropServices.FieldOffset(64)]
    public short dmYResolution;
    [System.Runtime.InteropServices.FieldOffset(66)]
    public short dmTTOption;
    [System.Runtime.InteropServices.FieldOffset(68)]
    public short dmCollate; // See note below!
    [System.Runtime.InteropServices.FieldOffset(72)]
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
    public string dmFormName;
    [System.Runtime.InteropServices.FieldOffset(102)]
    public Int16 dmLogPixels;
    [System.Runtime.InteropServices.FieldOffset(104)]
    public Int32 dmBitsPerPel;
    [System.Runtime.InteropServices.FieldOffset(108)]
    public Int32 dmPelsWidth;
    [System.Runtime.InteropServices.FieldOffset(112)]
    public Int32 dmPelsHeight;
    [System.Runtime.InteropServices.FieldOffset(116)]
    public Int32 dmDisplayFlags;
    [System.Runtime.InteropServices.FieldOffset(116)]
    public Int32 dmNup;
    [System.Runtime.InteropServices.FieldOffset(120)]
    public Int32 dmDisplayFrequency;
}
    struct POINTL
{
    public Int32 x; 
    public Int32 y;
}
    [Flags()]
enum DM : int
{
    Orientation = 0x1,
    PaperSize = 0x2,
    PaperLength = 0x4,
    PaperWidth = 0x8,
    Scale = 0x10,
    Position = 0x20,
    NUP = 0x40,
    DisplayOrientation = 0x80,
    Copies = 0x100,
    DefaultSource = 0x200,
    PrintQuality = 0x400,
    Color = 0x800,
    Duplex = 0x1000,
    YResolution = 0x2000,
    TTOption = 0x4000,
    Collate = 0x8000,
    FormName = 0x10000,
    LogPixels = 0x20000,
    BitsPerPixel = 0x40000,
    PelsWidth = 0x80000,
    PelsHeight = 0x100000,
    DisplayFlags = 0x200000,
    DisplayFrequency = 0x400000,
    ICMMethod = 0x800000,
    ICMIntent = 0x1000000,
    MediaType = 0x2000000,
    DitherType = 0x4000000,
    PanningWidth = 0x8000000,
    PanningHeight = 0x10000000,
    DisplayFixedOutput = 0x20000000
}

    public partial class EkranÇözünürlüğü : Form
    {

        [DllImport("user32.dll")]
        static extern DISP_CHANGE ChangeDisplaySettings(ref DEVMODE devMode, int flags);
        [DllImport("user32.dll")]
        static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);
        DEVMODE dm;

        public EkranÇözünürlüğü()
        {
            InitializeComponent();
        }

        private void EkranÇözünürlüğü_Load(object sender, EventArgs e)
        {
            dm=new DEVMODE();
            int sayac=0;
            while (EnumDisplaySettings(null, sayac, ref dm))
            {
                bool durum = true;
                string yazılacak=dm.dmPelsWidth +":"+dm.dmPelsHeight+":"+dm.dmDisplayFrequency;

                foreach (string item in listBox1.Items)
                {
                    if (yazılacak == item)
                        durum = false;
                }
                if(durum)
                    listBox1.Items.Add(yazılacak);
                sayac++;
            }

        }

        const int test = 2;
        const int degistirme = 1;
        const int deneme = 4;
        private void button1_Click(object sender, EventArgs e)
        {
            dm.dmPelsWidth = int.Parse(textBox1.Text);
            dm.dmPelsHeight = int.Parse(textBox2.Text);
            dm.dmDisplayFrequency = int.Parse(textBox3.Text);
            DISP_CHANGE sonuc = ChangeDisplaySettings(ref dm, deneme);
            if (sonuc == DISP_CHANGE.Successful)

                MessageBox.Show("İşleminiz Başarılı");
            else
                MessageBox.Show("HATA");
        }
    }
}
