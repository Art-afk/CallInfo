using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace CallInfo
{


    [BroadcastReceiver(Enabled = true)]
    [IntentFilter(new string[] { MySampleBroadcastReceiver.MyAction})]
    public class MySampleBroadcastReceiver : BroadcastReceiver
    {
        public const string MyAction = "com.mytest.services.MyReceiver.MyAction";
        public override void OnReceive(Context context, Intent intent)
        {

            if (intent.Action == "android.media.RINGER_MODE_CHANGED")
                Toast.MakeText(context, "Received intent!", ToastLength.Short).Show();

            if (intent != null)
            {
                Console.WriteLine("it works");
            }
        }
    }
}