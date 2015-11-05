//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using FannWrapper;
namespace FannWrapperFloat {

public class fann_layer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal fann_layer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(fann_layer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~fann_layer() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SwigFannFloatPINVOKE.delete_fann_layer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public fann_neuron first_neuron {
    set {
      SwigFannFloatPINVOKE.fann_layer_first_neuron_set(swigCPtr, fann_neuron.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannFloatPINVOKE.fann_layer_first_neuron_get(swigCPtr);
      fann_neuron ret = (cPtr == global::System.IntPtr.Zero) ? null : new fann_neuron(cPtr, false);
      return ret;
    } 
  }

  public fann_neuron last_neuron {
    set {
      SwigFannFloatPINVOKE.fann_layer_last_neuron_set(swigCPtr, fann_neuron.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannFloatPINVOKE.fann_layer_last_neuron_get(swigCPtr);
      fann_neuron ret = (cPtr == global::System.IntPtr.Zero) ? null : new fann_neuron(cPtr, false);
      return ret;
    } 
  }

  public fann_layer() : this(SwigFannFloatPINVOKE.new_fann_layer(), true) {
  }

}

}
