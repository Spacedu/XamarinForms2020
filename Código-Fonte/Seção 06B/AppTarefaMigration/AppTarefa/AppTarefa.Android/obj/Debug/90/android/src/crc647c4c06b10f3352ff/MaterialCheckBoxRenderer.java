package crc647c4c06b10f3352ff;


public class MaterialCheckBoxRenderer
	extends crc643f46942d9dd1fff9.CheckBoxRendererBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Material.Android.MaterialCheckBoxRenderer, Xamarin.Forms.Material", MaterialCheckBoxRenderer.class, __md_methods);
	}


	public MaterialCheckBoxRenderer (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialCheckBoxRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialCheckBoxRenderer, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialCheckBoxRenderer (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialCheckBoxRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialCheckBoxRenderer, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialCheckBoxRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialCheckBoxRenderer.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialCheckBoxRenderer, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
