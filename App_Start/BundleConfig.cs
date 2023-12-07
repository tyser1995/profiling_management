using System.Web;
using System.Web.Optimization;

namespace profiling_management
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                   "~/adminlte/plugins/bootstrap/js/bootstrap.bundle.min.js",
                   "~/adminlte/plugins/jquery-ui/jquery-ui.min.js",
                   "~/adminlte/plugins/chart.js/Chart.min.js",
                   "~/adminlte/plugins/sparklines/sparkline.js",
                   "~/adminlte/plugins/jqvmap/jquery.vmap.min.js",
                   "~/adminlte/plugins/jqvmap/maps/jquery.vmap.usa.js",
                   "~/adminlte/plugins/jquery-knob/jquery.knob.min.js",
                   "~/adminlte/plugins/moment/moment.min.js",
                   "~/adminlte/plugins/daterangepicker/daterangepicker.js",
                   "~/adminlte/plugins/tempusdominus-bootstrap-4/js/tempusdominus-bootstrap-4.min.js",
                   "~/adminlte/plugins/summernote/summernote-bs4.min.js",
                   "~/adminlte/plugins/overlayScrollbars/js/jquery.overlayScrollbars.min.js",
                   "~/adminlte/plugins/bootstrap-switch/js/bootstrap-switch.min.js",
                   "~/adminlte/plugins/bs-stepper/js/bs-stepper.min.js",
                   "~/adminlte/plugins/dropzone/min/dropzone.min.js",
                   "~/adminlte/plugins/select2/js/select2.full.min.js",
                   "~/adminlte/plugins/inputmask/jquery.inputmask.min.js",
                   "~/adminlte/plugins/sweetalert2/sweetalert2.min.js",
                   "~/adminlte/plugins/toastr/toastr.min.js",
                   "~/adminlte/plugins/datatables/jquery.dataTables.min.js",
                   "~/adminlte/plugins/datatables-bs4/js/dataTables.bootstrap4.min.js",
                   "~/adminlte/plugins/datatables-responsive/js/dataTables.responsive.min.js",
                   "~/adminlte/plugins/datatables-responsive/js/responsive.bootstrap4.min.js",
                   "~/adminlte/plugins/datatables-buttons/js/dataTables.buttons.min.js",
                   "~/adminlte/plugins/datatables-buttons/js/buttons.bootstrap4.min.js",
                   "~/adminlte/plugins/jszip/jszip.min.js",
                  "~/Scripts/dataTables.checkboxes.min.js",
                   "~/adminlte/dist/js/adminlte.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    "~/adminlte/dist/css/adminlte.min.css",
                    "~/adminlte/plugins/fontawesome-free/css/all.min.css",
                    "~/adminlte/plugins/overlayScrollbars/css/OverlayScrollbars.min.css",
                    "~/adminlte/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                    "~/adminlte/plugins/tempusdominus-bootstrap-4/css/tempusdominus-bootstrap-4.min.css",
                    "~/adminlte/plugins/icheck-bootstrap/icheck-bootstrap.min.css",
                    "~/adminlte/plugins/jqvmap/jqvmap.min.css",
                    "~/adminlte/plugins/daterangepicker/daterangepicker.css",
                    "~/adminlte/plugins/summernote/summernote-bs4.min.css",
                    "~/adminlte/plugins/select2/css/select2.min.css",
                    "~/adminlte/plugins/select2-bootstrap4-theme/select2-bootstrap4.min.css",
                    "~/adminlte/plugins/bs-stepper/css/bs-stepper.min.css",
                    "~/adminlte/plugins/dropzone/min/dropzone.min.css",
                    "~/adminlte/plugins/sweetalert2-theme-bootstrap-4/bootstrap-4.min.css",
                    "~/adminlte/plugins/toastr/toastr.min.css",
                    "~/adminlte/plugins/datatables-bs4/css/dataTables.bootstrap4.min.css",
                    "~/adminlte/plugins/datatables-responsive/css/responsive.bootstrap4.min.css"
                    ));
        }
    }
}
