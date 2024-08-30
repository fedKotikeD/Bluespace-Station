﻿//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue.Interop
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.InteropServices;
    using System.Security;
    
    [StructLayout(LayoutKind.Sequential, Pack = libcef.ALIGN)]
    [SuppressMessage("Microsoft.Design", "CA1049:TypesThatOwnNativeResourcesShouldBeDisposable")]
    internal unsafe struct cef_file_dialog_callback_t
    {
        internal cef_base_ref_counted_t _base;
        internal delegate* unmanaged<cef_file_dialog_callback_t*, cef_string_list*, void> _cont;
        internal delegate* unmanaged<cef_file_dialog_callback_t*, void> _cancel;
        
        // AddRef
        
        public static void add_ref(cef_file_dialog_callback_t* self)
        {
            self->_base._add_ref((cef_base_ref_counted_t*)self);
        }
        
        // Release
        
        public static int release(cef_file_dialog_callback_t* self)
        {
            return self->_base._release((cef_base_ref_counted_t*)self);
        }
        
        // HasOneRef
        
        public static int has_one_ref(cef_file_dialog_callback_t* self)
        {
            return self->_base._has_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // HasAtLeastOneRef
        
        public static int has_at_least_one_ref(cef_file_dialog_callback_t* self)
        {
            return self->_base._has_at_least_one_ref((cef_base_ref_counted_t*)self);
        }
        
        // Continue
        
        public static void cont(cef_file_dialog_callback_t* self, cef_string_list* file_paths)
        {
            self->_cont(self, file_paths);
        }
        
        // Cancel
        
        public static void cancel(cef_file_dialog_callback_t* self)
        {
            self->_cancel(self);
        }
        
    }
}
