using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Moq;
using Newtonsoft.Json;

namespace WCFBusinessLogic.Helper {

        public static class Helper {

            public static void AddQueryData<T>(this Mock source, IQueryable<T> data) {
                source.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
                source.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
                source.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
                source.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
            }

            public static T Clone<T>(this T source) {
                // Don't serialize a null object, simply return the default for that object
                if (Object.ReferenceEquals(source, null)) {
                    return default(T);
                }

                T ret = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source));

                return ret;
            }

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
