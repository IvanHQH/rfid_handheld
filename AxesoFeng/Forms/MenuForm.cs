using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RestSharp;
using System.IO;
using ReadWriteCsv;
using Newtonsoft.Json;
using System.Reflection;
using AxesoFeng.Forms;


namespace AxesoFeng
{
    public partial class MenuForm : BaseForm
    {
        //Child Forms
        public CaptureFolio data;
        public InventoryReportFrm reports;
        public SearchForm search;
        public UPCSearchForm upcsearch;
        public LocateForm locate;
        //public OrderExitForm orderexit;
        public OrderExitReportForm orderreport;
        public SyncForm formsync;
        public int idCustomer = 0;
        public bool showCaptureFolio;

        //RFID Reader
        public SimpleRFID rrfid;

        //Catalogs
        public ProductsList products;
        //public ProductsList products_bar;
        public Warehouses warehouses;

        //Synchronization
        public Sync sync;

        //Current Event Data
        //public EventData eventdata;

        //Configuration
        public Config configData;

        public string myResDir;

        public enum typeFolio { loading = 1,unloading = 2}

        public MenuForm()
        {
            InitializeComponent();
            //Set Config Data
            configData = Config.getConfig(@"\rfiddata\config.json");
            idCustomer = configData.id_customer;
            showCaptureFolio = true;
            //Set Synchronization
            sync = new Sync(configData.url);
            //sync.GETTest();
            //sync.GET();
            //Set Reader
            rrfid = new SimpleRFID();
            //rrfid.changeEPC("30342848A80A5AC0000007D9", "30342848A80A5A400001000A");
            //Set Catalogs
            products = new ProductsList(@"\rfiddata\products.csv");
            //products_bar = new ProductsList(@"\rfiddata\products_bar.csv");
            warehouses = new Warehouses(@"\rfiddata\warehouses.csv");

            //Set Current Event Data
            //eventdata = EventData.getEventData();

            //Set Forms
            //data = new InventoryForm(this);
            //data = new CaptureFolio(this);
            reports = new InventoryReportFrm(this);
            search = new SearchForm(this);
            upcsearch = new UPCSearchForm(this);
            locate = new LocateForm(this);
            formsync = new SyncForm(this);
            //orderexit = new OrderExitForm(this);
            orderreport = new OrderExitReportForm(this);
            //Sync sync = new Sync(configData.url);
            //sync.UpdatedDataBase();
            this.setColors(configData);
            /*
            Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(@"\rfiddata\img\logo.bmp");
            Image image = new Bitmap(stream);
            LogoPicture.Image = image;
              */

            string myDir = Path.GetDirectoryName(Assembly.GetCallingAssembly().GetName().CodeBase);
            myResDir = Path.Combine(myDir, @"\rfiddata\img");
            Image image;
            
            image = new Bitmap(Path.Combine(myResDir, "logo_hqh_med.bmp"));
            LogoPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "menu1.bmp"));
            ReaderPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "menu2.bmp"));
            ReportPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "menu3.bmp"));
            SearchPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "menu4.bmp"));
            SyncPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "menu5_export.bmp"));
            OrderExitPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "menu6.bmp"));
            OrderExitReportPicture.Image = image;
            image = new Bitmap(Path.Combine(myResDir, "exit.bmp"));
            ExitPicture.Image = image;


        }

        private void ExitPicture_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReaderPicture_Click(object sender, EventArgs e)
        {
            data = new CaptureFolio(this,MenuForm.typeFolio.unloading);
            data.Show();
        }

        private void ReportPicture_Click(object sender, EventArgs e)
        {
            reports.Show();
        }

        private void SearchPicture_Click(object sender, EventArgs e)
        {
            search.Show();
        }

        private void SyncPicture_Click(object sender, EventArgs e)
        {
            
            formsync.Show();
            
            //if (!sync.GET())
            //    return;
            products = new ProductsList(@"\rfiddata\products.csv");
            //products_bar = new ProductsList(@"\rfiddata\products_bar.csv");
            warehouses = new Warehouses(@"\rfiddata\warehouses.csv");
            if (sync.POST(formsync))
                MessageBox.Show("Sincronización exitosa", "Sincronización");
            formsync.Hide();
        }

        private void OrderExitReportPicture_Click(object sender, EventArgs e)
        {
            orderreport.Show();
        }

        private void OrderExitPicture_Click(object sender, EventArgs e)
        {
            //orderexit.Show();
            data = new CaptureFolio(this, MenuForm.typeFolio.loading);
            data.Show();
        }

        private void pbClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar todas las lecturas?", "Confirmación", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            FolioOrder.DeleteFiles();
        }

    }
}