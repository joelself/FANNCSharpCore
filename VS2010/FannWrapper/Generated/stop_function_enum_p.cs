//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace FannWrap {

public class stop_function_enum_p : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal stop_function_enum_p(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(stop_function_enum_p obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~stop_function_enum_p() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SwigFannPINVOKE.delete_stop_function_enum_p(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public stop_function_enum_p() : this(SwigFannPINVOKE.new_stop_function_enum_p(), true) {
  }

  public void assign(SWIGTYPE_p_stop_function_enum value) {
    SwigFannPINVOKE.stop_function_enum_p_assign(swigCPtr, SWIGTYPE_p_stop_function_enum.getCPtr(value));
    if (SwigFannPINVOKE.SWIGPendingException.Pending) throw SwigFannPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_stop_function_enum value() {
    SWIGTYPE_p_stop_function_enum ret = new SWIGTYPE_p_stop_function_enum(SwigFannPINVOKE.stop_function_enum_p_value(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_stop_function_enum cast() {
    global::System.IntPtr cPtr = SwigFannPINVOKE.stop_function_enum_p_cast(swigCPtr);
    SWIGTYPE_p_stop_function_enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_stop_function_enum(cPtr, false);
    return ret;
  }

  public static stop_function_enum_p frompointer(SWIGTYPE_p_stop_function_enum t) {
    global::System.IntPtr cPtr = SwigFannPINVOKE.stop_function_enum_p_frompointer(SWIGTYPE_p_stop_function_enum.getCPtr(t));
    stop_function_enum_p ret = (cPtr == global::System.IntPtr.Zero) ? null : new stop_function_enum_p(cPtr, false);
    return ret;
  }

}

}
