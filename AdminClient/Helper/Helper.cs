using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WCFBusinessLogic.Helper {

        public static class Helper {

            public static void DebugGetLine(this Exception ex) {
#if DEBUG
                Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;

                Trace.WriteLine("\n\n\n ##### DEBUG EXCEPTION ##### \n");
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(0);
                // Get the line number from the stack frame
                Trace.WriteLine(String.Format("Exception: {0}", ex));

                var stackFrames = st.GetFrames();
                if (stackFrames != null)
                    foreach (var stackFrame in stackFrames) {
                        Trace.WriteLine(String.Format("File: {0} Line: {1} Exception Cought", stackFrame.GetFileName(), stackFrame.GetFileLineNumber()));
                    }
                Trace.WriteLine("\n ########################### \n\n");
                Debug.WriteLine(String.Format("File: {0} Line: {1} Exception Cought", frame.GetFileName(),frame.GetFileLineNumber()));
#endif
            }
        }
    
}
