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
namespace FannWrapperDouble {

public class fann : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal fann(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(fann obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~fann() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          SwigFannDoublePINVOKE.delete_fann(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SWIGTYPE_fann_errno_enum errno_f {
    set {
      SwigFannDoublePINVOKE.fann_errno_f_set(swigCPtr, (int)value);
    } 
    get {
      SWIGTYPE_fann_errno_enum ret = (SWIGTYPE_fann_errno_enum)SwigFannDoublePINVOKE.fann_errno_f_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_FILE error_log {
    set {
      SwigFannDoublePINVOKE.fann_error_log_set(swigCPtr, SWIGTYPE_p_FILE.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_error_log_get(swigCPtr);
      SWIGTYPE_p_FILE ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_FILE(cPtr, false);
      return ret;
    } 
  }

  public string errstr {
    set {
      SwigFannDoublePINVOKE.fann_errstr_set(swigCPtr, value);
    } 
    get {
      string ret = SwigFannDoublePINVOKE.fann_errstr_get(swigCPtr);
      return ret;
    } 
  }

  public float learning_rate {
    set {
      SwigFannDoublePINVOKE.fann_learning_rate_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_learning_rate_get(swigCPtr);
      return ret;
    } 
  }

  public float learning_momentum {
    set {
      SwigFannDoublePINVOKE.fann_learning_momentum_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_learning_momentum_get(swigCPtr);
      return ret;
    } 
  }

  public float connection_rate {
    set {
      SwigFannDoublePINVOKE.fann_connection_rate_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_connection_rate_get(swigCPtr);
      return ret;
    } 
  }

  public fann_nettype_enum network_type {
    set {
      SwigFannDoublePINVOKE.fann_network_type_set(swigCPtr, (int)value);
    } 
    get {
      fann_nettype_enum ret = (fann_nettype_enum)SwigFannDoublePINVOKE.fann_network_type_get(swigCPtr);
      return ret;
    } 
  }

  public fann_layer first_layer {
    set {
      SwigFannDoublePINVOKE.fann_first_layer_set(swigCPtr, fann_layer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_first_layer_get(swigCPtr);
      fann_layer ret = (cPtr == global::System.IntPtr.Zero) ? null : new fann_layer(cPtr, false);
      return ret;
    } 
  }

  public fann_layer last_layer {
    set {
      SwigFannDoublePINVOKE.fann_last_layer_set(swigCPtr, fann_layer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_last_layer_get(swigCPtr);
      fann_layer ret = (cPtr == global::System.IntPtr.Zero) ? null : new fann_layer(cPtr, false);
      return ret;
    } 
  }

  public uint total_neurons {
    set {
      SwigFannDoublePINVOKE.fann_total_neurons_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_total_neurons_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_input {
    set {
      SwigFannDoublePINVOKE.fann_num_input_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_num_input_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_output {
    set {
      SwigFannDoublePINVOKE.fann_num_output_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_num_output_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double weights {
    set {
      SwigFannDoublePINVOKE.fann_weights_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_weights_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_p_fann_neuron connections {
    set {
      SwigFannDoublePINVOKE.fann_connections_set(swigCPtr, SWIGTYPE_p_p_fann_neuron.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_connections_get(swigCPtr);
      SWIGTYPE_p_p_fann_neuron ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_p_fann_neuron(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double train_errors {
    set {
      SwigFannDoublePINVOKE.fann_train_errors_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_train_errors_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public fann_train_enum training_algorithm {
    set {
      SwigFannDoublePINVOKE.fann_training_algorithm_set(swigCPtr, (int)value);
    } 
    get {
      fann_train_enum ret = (fann_train_enum)SwigFannDoublePINVOKE.fann_training_algorithm_get(swigCPtr);
      return ret;
    } 
  }

  public uint total_connections {
    set {
      SwigFannDoublePINVOKE.fann_total_connections_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_total_connections_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double output {
    set {
      SwigFannDoublePINVOKE.fann_output_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_output_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public uint num_MSE {
    set {
      SwigFannDoublePINVOKE.fann_num_MSE_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_num_MSE_get(swigCPtr);
      return ret;
    } 
  }

  public float MSE_value {
    set {
      SwigFannDoublePINVOKE.fann_MSE_value_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_MSE_value_get(swigCPtr);
      return ret;
    } 
  }

  public uint num_bit_fail {
    set {
      SwigFannDoublePINVOKE.fann_num_bit_fail_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_num_bit_fail_get(swigCPtr);
      return ret;
    } 
  }

  public double bit_fail_limit {
    set {
      SwigFannDoublePINVOKE.fann_bit_fail_limit_set(swigCPtr, value);
    } 
    get {
      double ret = SwigFannDoublePINVOKE.fann_bit_fail_limit_get(swigCPtr);
      return ret;
    } 
  }

  public fann_errorfunc_enum train_error_function {
    set {
      SwigFannDoublePINVOKE.fann_train_error_function_set(swigCPtr, (int)value);
    } 
    get {
      fann_errorfunc_enum ret = (fann_errorfunc_enum)SwigFannDoublePINVOKE.fann_train_error_function_get(swigCPtr);
      return ret;
    } 
  }

  public fann_stopfunc_enum train_stop_function {
    set {
      SwigFannDoublePINVOKE.fann_train_stop_function_set(swigCPtr, (int)value);
    } 
    get {
      fann_stopfunc_enum ret = (fann_stopfunc_enum)SwigFannDoublePINVOKE.fann_train_stop_function_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int callback {
    set {
      SwigFannDoublePINVOKE.fann_callback_set(swigCPtr, SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_callback_get(swigCPtr);
      SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_f_p_fann_p_fann_train_data_unsigned_int_unsigned_int_float_unsigned_int__int(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_void user_data {
    set {
      SwigFannDoublePINVOKE.fann_user_data_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_user_data_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public float cascade_output_change_fraction {
    set {
      SwigFannDoublePINVOKE.fann_cascade_output_change_fraction_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_cascade_output_change_fraction_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_output_stagnation_epochs {
    set {
      SwigFannDoublePINVOKE.fann_cascade_output_stagnation_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_output_stagnation_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public float cascade_candidate_change_fraction {
    set {
      SwigFannDoublePINVOKE.fann_cascade_candidate_change_fraction_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_cascade_candidate_change_fraction_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_candidate_stagnation_epochs {
    set {
      SwigFannDoublePINVOKE.fann_cascade_candidate_stagnation_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_candidate_stagnation_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_best_candidate {
    set {
      SwigFannDoublePINVOKE.fann_cascade_best_candidate_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_best_candidate_get(swigCPtr);
      return ret;
    } 
  }

  public double cascade_candidate_limit {
    set {
      SwigFannDoublePINVOKE.fann_cascade_candidate_limit_set(swigCPtr, value);
    } 
    get {
      double ret = SwigFannDoublePINVOKE.fann_cascade_candidate_limit_get(swigCPtr);
      return ret;
    } 
  }

  public double cascade_weight_multiplier {
    set {
      SwigFannDoublePINVOKE.fann_cascade_weight_multiplier_set(swigCPtr, value);
    } 
    get {
      double ret = SwigFannDoublePINVOKE.fann_cascade_weight_multiplier_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_max_out_epochs {
    set {
      SwigFannDoublePINVOKE.fann_cascade_max_out_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_max_out_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_max_cand_epochs {
    set {
      SwigFannDoublePINVOKE.fann_cascade_max_cand_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_max_cand_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_min_out_epochs {
    set {
      SwigFannDoublePINVOKE.fann_cascade_min_out_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_min_out_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_min_cand_epochs {
    set {
      SwigFannDoublePINVOKE.fann_cascade_min_cand_epochs_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_min_cand_epochs_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_fann_activationfunc_enum cascade_activation_functions {
    set {
      SwigFannDoublePINVOKE.fann_cascade_activation_functions_set(swigCPtr, SWIGTYPE_p_fann_activationfunc_enum.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_cascade_activation_functions_get(swigCPtr);
      SWIGTYPE_p_fann_activationfunc_enum ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_fann_activationfunc_enum(cPtr, false);
      return ret;
    } 
  }

  public uint cascade_activation_functions_count {
    set {
      SwigFannDoublePINVOKE.fann_cascade_activation_functions_count_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_activation_functions_count_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double cascade_activation_steepnesses {
    set {
      SwigFannDoublePINVOKE.fann_cascade_activation_steepnesses_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_cascade_activation_steepnesses_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public uint cascade_activation_steepnesses_count {
    set {
      SwigFannDoublePINVOKE.fann_cascade_activation_steepnesses_count_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_activation_steepnesses_count_get(swigCPtr);
      return ret;
    } 
  }

  public uint cascade_num_candidate_groups {
    set {
      SwigFannDoublePINVOKE.fann_cascade_num_candidate_groups_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_cascade_num_candidate_groups_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double cascade_candidate_scores {
    set {
      SwigFannDoublePINVOKE.fann_cascade_candidate_scores_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_cascade_candidate_scores_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public uint total_neurons_allocated {
    set {
      SwigFannDoublePINVOKE.fann_total_neurons_allocated_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_total_neurons_allocated_get(swigCPtr);
      return ret;
    } 
  }

  public uint total_connections_allocated {
    set {
      SwigFannDoublePINVOKE.fann_total_connections_allocated_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_total_connections_allocated_get(swigCPtr);
      return ret;
    } 
  }

  public float quickprop_decay {
    set {
      SwigFannDoublePINVOKE.fann_quickprop_decay_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_quickprop_decay_get(swigCPtr);
      return ret;
    } 
  }

  public float quickprop_mu {
    set {
      SwigFannDoublePINVOKE.fann_quickprop_mu_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_quickprop_mu_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_increase_factor {
    set {
      SwigFannDoublePINVOKE.fann_rprop_increase_factor_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_rprop_increase_factor_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_decrease_factor {
    set {
      SwigFannDoublePINVOKE.fann_rprop_decrease_factor_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_rprop_decrease_factor_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_delta_min {
    set {
      SwigFannDoublePINVOKE.fann_rprop_delta_min_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_rprop_delta_min_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_delta_max {
    set {
      SwigFannDoublePINVOKE.fann_rprop_delta_max_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_rprop_delta_max_get(swigCPtr);
      return ret;
    } 
  }

  public float rprop_delta_zero {
    set {
      SwigFannDoublePINVOKE.fann_rprop_delta_zero_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_rprop_delta_zero_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_weight_decay_shift {
    set {
      SwigFannDoublePINVOKE.fann_sarprop_weight_decay_shift_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_sarprop_weight_decay_shift_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_step_error_threshold_factor {
    set {
      SwigFannDoublePINVOKE.fann_sarprop_step_error_threshold_factor_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_sarprop_step_error_threshold_factor_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_step_error_shift {
    set {
      SwigFannDoublePINVOKE.fann_sarprop_step_error_shift_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_sarprop_step_error_shift_get(swigCPtr);
      return ret;
    } 
  }

  public float sarprop_temperature {
    set {
      SwigFannDoublePINVOKE.fann_sarprop_temperature_set(swigCPtr, value);
    } 
    get {
      float ret = SwigFannDoublePINVOKE.fann_sarprop_temperature_get(swigCPtr);
      return ret;
    } 
  }

  public uint sarprop_epoch {
    set {
      SwigFannDoublePINVOKE.fann_sarprop_epoch_set(swigCPtr, value);
    } 
    get {
      uint ret = SwigFannDoublePINVOKE.fann_sarprop_epoch_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_double train_slopes {
    set {
      SwigFannDoublePINVOKE.fann_train_slopes_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_train_slopes_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double prev_steps {
    set {
      SwigFannDoublePINVOKE.fann_prev_steps_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_prev_steps_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double prev_train_slopes {
    set {
      SwigFannDoublePINVOKE.fann_prev_train_slopes_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_prev_train_slopes_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_double prev_weights_deltas {
    set {
      SwigFannDoublePINVOKE.fann_prev_weights_deltas_set(swigCPtr, SWIGTYPE_p_double.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_prev_weights_deltas_get(swigCPtr);
      SWIGTYPE_p_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_double(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_mean_in {
    set {
      SwigFannDoublePINVOKE.fann_scale_mean_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_mean_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_deviation_in {
    set {
      SwigFannDoublePINVOKE.fann_scale_deviation_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_deviation_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_new_min_in {
    set {
      SwigFannDoublePINVOKE.fann_scale_new_min_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_new_min_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_factor_in {
    set {
      SwigFannDoublePINVOKE.fann_scale_factor_in_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_factor_in_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_mean_out {
    set {
      SwigFannDoublePINVOKE.fann_scale_mean_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_mean_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_deviation_out {
    set {
      SwigFannDoublePINVOKE.fann_scale_deviation_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_deviation_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_new_min_out {
    set {
      SwigFannDoublePINVOKE.fann_scale_new_min_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_new_min_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_float scale_factor_out {
    set {
      SwigFannDoublePINVOKE.fann_scale_factor_out_set(swigCPtr, SWIGTYPE_p_float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = SwigFannDoublePINVOKE.fann_scale_factor_out_get(swigCPtr);
      SWIGTYPE_p_float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_float(cPtr, false);
      return ret;
    } 
  }

  public fann() : this(SwigFannDoublePINVOKE.new_fann(), true) {
  }

}

}
