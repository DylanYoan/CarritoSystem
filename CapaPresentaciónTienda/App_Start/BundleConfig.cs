﻿using System.Web;
using System.Web.Optimization;

namespace CapaPresentaciónTienda
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Utilice la versión de desarrollo de Modernizr para desarrollar y obtener información sobre los formularios.  De esta manera estará
            //// para la producción, use la herramienta de compilación disponible en https://modernizr.com para seleccionar solo las pruebas que necesite.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new Bundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js",
                      "~/Scripts/fontawesome/all.min.js",
                      "~/Scripts/jquery-loading-overlay/loadingoverlay.min.js",
                      "~/Scripts/sweetalert.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css",
                      "~/Content/sweetalert.css",
                      "~/Content/Style.css"
                      ));
            
            bundles.Add(new StyleBundle("~/Content/Inicio").Include(
                      "~/Content/backgroundTienda.css",
                      "~/Content/styleTienda.css"
                      ));
            
            bundles.Add(new StyleBundle("~/Content/DetalleProducto_Carrito").Include(
                      "~/Content/styleTienda.css"
                      ));
            
            bundles.Add(new StyleBundle("~/Content/Items").Include(
                      "~/Content/backgroundTienda.css",
                      "~/Content/itemsTienda.css"
                      ));

            bundles.Add(new StyleBundle("~/Content/Login").Include(
                      "~/Content/login_styles.css"
                      ));

        }
    }
}
