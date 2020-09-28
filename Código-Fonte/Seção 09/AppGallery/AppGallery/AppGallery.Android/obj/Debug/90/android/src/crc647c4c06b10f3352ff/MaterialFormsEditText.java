package crc647c4c06b10f3352ff;


public class MaterialFormsEditText
	extends crc647c4c06b10f3352ff.MaterialFormsEditTextBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onKeyPreIme:(ILandroid/view/KeyEvent;)Z:GetOnKeyPreIme_ILandroid_view_KeyEvent_Handler\n" +
			"n_onSelectionChanged:(II)V:GetOnSelectionChanged_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Material.Android.MaterialFormsEditText, Xamarin.Forms.Material", MaterialFormsEditText.class, __md_methods);
	}


	public MaterialFormsEditText (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialFormsEditText.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsEditText, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialFormsEditText (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialFormsEditText.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsEditText, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialFormsEditText (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialFormsEditText.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsEditText, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onKeyPreIme (int p0, android.view.KeyEvent p1)
	{
		return n_onKeyPreIme (p0, p1);
	}

	private native boolean n_onKeyPreIme (int p0, android.view.KeyEvent p1);


	public void onSelectionChanged (int p0, int p1)
	{
		n_onSelectionChanged (p0, p1);
	}

	private native void n_onSelectionChanged (int p0, int p1);

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
