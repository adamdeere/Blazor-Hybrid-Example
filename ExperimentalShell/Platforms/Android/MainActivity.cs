using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace ExperimentalShell.Platforms.Android;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    public static ZebraScanReceiver receiver;
    public static EMDKWrapper emdkWrapper;
    public static PackageInstallerStatusReceiver packageInstallerStatusReceiver;

    protected override void OnCreate(Bundle bundle)
    {
        base.OnCreate(bundle);
        receiver = new ZebraScanReceiver();

        try
        {
            System.Diagnostics.Debug.WriteLine("register broadcast receiver");
            //packageInstallerStatusReceiver = new PackageInstallerStatusReceiver();
            //RegisterReceiver(packageInstallerStatusReceiver, new IntentFilter(UpgradeHelper.PACKAGE_INSTALLED_ACTION));
            System.Diagnostics.Debug.WriteLine("after register broadcast receiver");
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine("PackageInstallerStatusReceiver ERROR");
            System.Diagnostics.Debug.WriteLine(ex);
        }

        //if (android.os.Build.MANUFACTURER.contains("Zebra Technologies") || android.os.Build.MANUFACTURER.contains("Motorola Solutions"))
        //{
        try
        {
            emdkWrapper = new EMDKWrapper();
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
            //ignore and presume its not a symbol/zebra/motorola device
        }
        //}

    }

    protected override void OnResume()
    {
        base.OnResume();
        try
        {
            RegisterReceiver(receiver, new IntentFilter("com.IMS.PlatinumWMSSwift.scan"));

        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }

    }
    protected override void OnPause()
    {
        base.OnPause();
        try
        {
            UnregisterReceiver(receiver);
            //UnregisterReceiver(packageInstallerStatusReceiver);
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex);
        }
    }
}
