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
namespace FannWrapperFixed {

public class fann_neuron : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal fann_neuron(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(fann_neuron obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~fann_neuron() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SwigFannFixedPINVOKE.delete_fann_neuron(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint first_con {
    set {
      SwigFannFixedPINVOKE.fann_neuron_first_con_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannFixedPINVOKE.fann_neuron_first_con_get(swigCPtr);
      return ret;
    } 
  }

  public uint last_con {
    set {
      SwigFannFixedPINVOKE.fann_neuron_last_con_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannFixedPINVOKE.fann_neuron_last_con_get(swigCPtr);
      return ret;
    } 
  }

  public int sum {
    set {
      SwigFannFixedPINVOKE.fann_neuron_sum_set(swigCPtr, value);
    } 
    get {
      int ret = SwigFannFixedPINVOKE.fann_neuron_sum_get(swigCPtr);
      return ret;
    } 
  }

  public int value {
    set {
      SwigFannFixedPINVOKE.fann_neuron_value_set(swigCPtr, value);
    } 
    get {
      int ret = SwigFannFixedPINVOKE.fann_neuron_value_get(swigCPtr);
      return ret;
    } 
  }

  public int activation_steepness {
    set {
      SwigFannFixedPINVOKE.fann_neuron_activation_steepness_set(swigCPtr, value);
    } 
    get {
      int ret = SwigFannFixedPINVOKE.fann_neuron_activation_steepness_get(swigCPtr);
      return ret;
    } 
  }

  public fann_activationfunc_enum activation_function {
    set {
      SwigFannFixedPINVOKE.fann_neuron_activation_function_set(swigCPtr, (int)value);
    } 
    get {
      fann_activationfunc_enum ret = (fann_activationfunc_enum)SwigFannFixedPINVOKE.fann_neuron_activation_function_get(swigCPtr);
      return ret;
    } 
  }

  public fann_neuron() : this(SwigFannFixedPINVOKE.new_fann_neuron(), true) {
  }

}

}
