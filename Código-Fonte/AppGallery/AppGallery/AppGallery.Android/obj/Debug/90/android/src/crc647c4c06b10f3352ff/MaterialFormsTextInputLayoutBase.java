package crc647c4c06b10f3352ff;


public class MaterialFormsTextInputLayoutBase
	extends android.support.design.widget.TextInputLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getEditText:()Landroid/widget/EditText;:GetGetEditTextHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayoutBase, Xamarin.Forms.Material", MaterialFormsTextInputLayoutBase.class, __md_methods);
	}


	public MaterialFormsTextInputLayoutBase (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialFormsTextInputLayoutBase.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayoutBase, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialFormsTextInputLayoutBase (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialFormsTextInputLayoutBase.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayoutBase, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialFormsTextInputLayoutBase (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialFormsTextInputLayoutBase.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialFormsTextInputLayoutBase, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public android.widget.EditText getEditText ()
	{
		return n_getEditText ();
	}

	private native android.widget.EditText n_getEditText ();

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
