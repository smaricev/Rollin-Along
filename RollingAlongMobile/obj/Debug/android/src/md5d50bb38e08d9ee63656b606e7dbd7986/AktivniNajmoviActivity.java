package md5d50bb38e08d9ee63656b606e7dbd7986;


public class AktivniNajmoviActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("RollingAlongMobile.Najam.AktivniNajmoviActivity, RollingAlongMobile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", AktivniNajmoviActivity.class, __md_methods);
	}


	public AktivniNajmoviActivity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == AktivniNajmoviActivity.class)
			mono.android.TypeManager.Activate ("RollingAlongMobile.Najam.AktivniNajmoviActivity, RollingAlongMobile, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}