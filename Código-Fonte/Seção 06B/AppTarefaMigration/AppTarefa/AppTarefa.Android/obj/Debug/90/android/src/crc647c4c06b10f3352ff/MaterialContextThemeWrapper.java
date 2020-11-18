package crc647c4c06b10f3352ff;


public class MaterialContextThemeWrapper
	extends android.view.ContextThemeWrapper
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Material.Android.MaterialContextThemeWrapper, Xamarin.Forms.Material", MaterialContextThemeWrapper.class, __md_methods);
	}


	public MaterialContextThemeWrapper ()
	{
		super ();
		if (getClass () == MaterialContextThemeWrapper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialContextThemeWrapper, Xamarin.Forms.Material", "", this, new java.lang.Object[] {  });
	}


	public MaterialContextThemeWrapper (android.content.Context p0, android.content.res.Resources.Theme p1)
	{
		super (p0, p1);
		if (getClass () == MaterialContextThemeWrapper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialContextThemeWrapper, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Content.Res.Resources+Theme, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialContextThemeWrapper (android.content.Context p0, int p1)
	{
		super (p0, p1);
		if (getClass () == MaterialContextThemeWrapper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialContextThemeWrapper, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1 });
	}

	public MaterialContextThemeWrapper (android.content.Context p0)
	{
		super ();
		if (getClass () == MaterialContextThemeWrapper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialContextThemeWrapper, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}

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
