package crc647c4c06b10f3352ff;


public class MaterialPickerEditText
	extends crc647c4c06b10f3352ff.MaterialFormsEditTextBase
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onTouchEvent:(Landroid/view/MotionEvent;)Z:GetOnTouchEvent_Landroid_view_MotionEvent_Handler\n" +
			"n_onFocusChanged:(ZILandroid/graphics/Rect;)V:GetOnFocusChanged_ZILandroid_graphics_Rect_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Material.Android.MaterialPickerEditText, Xamarin.Forms.Material", MaterialPickerEditText.class, __md_methods);
	}


	public MaterialPickerEditText (android.content.Context p0)
	{
		super (p0);
		if (getClass () == MaterialPickerEditText.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialPickerEditText, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public MaterialPickerEditText (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == MaterialPickerEditText.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialPickerEditText, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public MaterialPickerEditText (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == MaterialPickerEditText.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Material.Android.MaterialPickerEditText, Xamarin.Forms.Material", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public boolean onTouchEvent (android.view.MotionEvent p0)
	{
		return n_onTouchEvent (p0);
	}

	private native boolean n_onTouchEvent (android.view.MotionEvent p0);


	public void onFocusChanged (boolean p0, int p1, android.graphics.Rect p2)
	{
		n_onFocusChanged (p0, p1, p2);
	}

	private native void n_onFocusChanged (boolean p0, int p1, android.graphics.Rect p2);

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
