using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Opc;
using Opc.Da;
using Factory = OpcCom.Factory;
using Server = Opc.Da.Server;

namespace Opc_Connection
{
    public partial class FrmOpcConnection : Form
    {
        public FrmOpcConnection()
        {
            InitializeComponent();
        }

        #region P R O P E R T I E S
        private Server _server;
        private Subscription _subscription;
        private Subscription _subscriptionWrite;
        private SubscriptionState _subscriptionState;
        private SubscriptionState _subscriptionStateWrite;
        private readonly Factory _factory = new Factory();


        private static string RtbRead { get; set; }
        private static string RtbDataChangedRead { get; set; }
        private static string RtbDataChangedWrite { get; set; }
        private string _toolStripStatus = string.Empty;
        private static bool Animation { get; set; }

        #endregion


        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {

                //=== Create a new server
                _server = new Server(_factory, null)
                {
                    Url = new URL(txtConnectionString.Text)
                };

                //=== Server Connection
                _server.Connect();

                //=== Create SubscriptionState from Subscription
                _subscriptionState = new SubscriptionState
                {
                    Name = "ReadGroup",
                    UpdateRate = 100,
                    Active = true
                };

                //=== Create a SubscriptionState to Subscription
                _subscriptionStateWrite = new SubscriptionState
                {
                    Name = "WriteGroup",
                    Active = false
                };


                //=== Subscription creation
                _subscription = (Subscription)_server.CreateSubscription(_subscriptionState);
                _subscriptionWrite = (Subscription)_server.CreateSubscription(_subscriptionStateWrite);


                //=== Associate the DataChangedEventHandler
                _subscription.DataChanged += new DataChangedEventHandler(SubscriptionRead_DataChanged);


                btReadWrite_Click(null, null);

                txtVariableRead_TextChanged(null, null);
                toolStripStatus.ToolTipText = string.Empty;
                toolStripStatus.Text = @"Connected";

            }
            catch (Exception ex)
            {
                toolStripStatus.ToolTipText = ex.Message;
                toolStripStatus.Text = @"Disconnected";

            }
        }
        
        private void SubscriptionRead_DataChanged(object subscriptionHandle, object requestHandle, ItemValueResult[] values)
        {
            if (!_server.IsConnected)
                RtbDataChangedRead = string.Empty;
            else
            {
                var item = values.FirstOrDefault(x => x.ItemName == txtVariableRead.Text);
                RtbDataChangedRead = item == null ? @"Variable NOT Found" : $"Variable:{item.ItemName}\n\nValue:{item.Value}\nQuality:{item.Quality.QualityBits.ToString()}\nTimeStamp:{item.Timestamp}";

            }

        }

        private void btReadWrite_Click(object sender, EventArgs e)
        {
            if (_server != null && _server.IsConnected)
            {
                _subscriptionWrite.RemoveItems(_subscriptionWrite.Items);
                _subscriptionWrite.AddItems(new[] { new Item { ItemName = txtVariableWrite.Text }, });


                var items = (ItemValueResult[])_subscriptionWrite.Read(_subscriptionWrite.Items);

                var item = items.FirstOrDefault(x => x.ItemName == txtVariableWrite.Text);
                RtbDataChangedWrite = item == null
                    ? @"Variable NOT Found."
                    : $"Variable:{item.ItemName}\n\nValue:{item.Value}\nQuality:{item.Quality.QualityBits.ToString()}\nTimeStamp:{item.Timestamp}";

            }
        }

        private void btWrite_Click(object sender, EventArgs e)
        {
            try
            {
                _subscriptionWrite.RemoveItems(_subscriptionWrite.Items);


                //IMPORTANT:
                //#1: assign the item to the group so the items gets a ServerHandle
                _subscriptionWrite.AddItems(new[] { new Item { ItemName = txtVariableWrite.Text } });

                // #2: assign the server handle to the ItemValue
                var itemValue = new ItemValue
                {
                    ServerHandle = _subscriptionWrite.Items.First().ServerHandle,
                    Value = txtWriteValue.Text
                };


                // #3: now write
                _subscriptionWrite.Write(new[] { itemValue });

                btReadWrite_Click(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Variable NOT Found;", @"Aborted.:", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }



        private void timerGui_Tick(object sender, EventArgs e)
        {
            backgroundWorkerTestConnection.RunWorkerAsync();

            rtbDataChangedRead.Text = RtbDataChangedRead;
            rtbDataChangedWrite.Text = RtbDataChangedWrite;
            rtbRead.Text = RtbRead;


            toolStripStatus.Text = _toolStripStatus;

            if (toolStripStatus.Text.Contains(@"Connected"))
                toolStripStatus.ForeColor = Animation ? Color.LimeGreen : Color.Black;
            else
                toolStripStatus.ForeColor = Animation ? Color.Red : Color.Black;

            Animation = !Animation;


        }

        private void backgroundWorkerTestConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var items = (ItemValueResult[])_server.Subscriptions[0].Read(_server.Subscriptions[0].Items);
                _toolStripStatus = @"Connected";

            }
            catch (Exception)
            {
                _toolStripStatus = @"Disconnected";
            }
        }
        
        private void txtVariableRead_TextChanged(object sender, EventArgs e)
        {
            if (_server != null && _server.IsConnected)
            {
                _subscription.RemoveItems(_subscription.Items);
                _subscription.AddItems(new[] { new Item { ItemName = txtVariableRead.Text }, });

                RtbDataChangedRead = @"Variable NOT Found;";
                RtbRead = string.Empty;
            }
        }
        
        private void btRead_Click(object sender, EventArgs e)
        {
            try
            {
                var items = (ItemValueResult[]) _subscription.Read(_subscription.Items);

                var item = items.FirstOrDefault(x => x.ItemName == txtVariableRead.Text);
                RtbRead = item == null
                    ? @"Variable NOT Found."
                    : $"Variable:{item.ItemName}\n\nValue:{item.Value}\nQuality:{item.Quality.QualityBits.ToString()}\nTimeStamp:{item.Timestamp}";


            }
            catch (Exception)
            {

            }
        }

        private void txtVariableWrite_TextChanged(object sender, EventArgs e)
        {
            btReadWrite_Click(null, null);
        }

        


    }
}
