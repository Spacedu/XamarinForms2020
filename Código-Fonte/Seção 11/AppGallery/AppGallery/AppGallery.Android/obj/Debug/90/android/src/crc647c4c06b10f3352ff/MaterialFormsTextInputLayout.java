package crc647c4c06b10f3352ff;


public class MaterialFormsTextInputLayout
	extends crc647c4c06b10f3352ff.MaterialFormsTextInputLayoutBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayout, Xamarin.Forms.Material", MaterialFormsTextInputLayout.class, __md_methods);
	}


	public MaterialFormsTextInputLayout (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialFormsTextInputLayout.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayout, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialFormsTextInputLayout (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialFormsTextInputLayout.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayout, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialFormsTextInputLayout (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialFormsTextInputLayout.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayout, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
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
