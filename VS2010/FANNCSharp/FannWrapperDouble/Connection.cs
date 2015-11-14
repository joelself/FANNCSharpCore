//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

using FANNCSharp;
namespace FannWrapperDouble {

internal class Connection : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Connection(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Connection obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Connection() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          fanndoublePINVOKE.delete_Connection(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public uint from_neuron {
    set {
      fanndoublePINVOKE.Connection_from_neuron_set(swigCPtr, value);
    } 
    get {
      uint ret = fanndoublePINVOKE.Connection_from_neuron_get(swigCPtr);
      return ret;
    } 
  }

  public uint to_neuron {
    set {
      fanndoublePINVOKE.Connection_to_neuron_set(swigCPtr, value);
    } 
    get {
      uint ret = fanndoublePINVOKE.Connection_to_neuron_get(swigCPtr);
      return ret;
    } 
  }

  public double weight {
    set {
      fanndoublePINVOKE.Connection_weight_set(swigCPtr, value);
    } 
    get {
      double ret = fanndoublePINVOKE.Connection_weight_get(swigCPtr);
      return ret;
    } 
  }

  public Connection() : this(fanndoublePINVOKE.new_Connection(), true) {
  }

}

}
