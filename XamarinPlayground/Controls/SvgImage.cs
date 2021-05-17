using System;
using System.Reflection;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;
using SKSvg = SkiaSharp.Extended.Svg.SKSvg;

namespace XamarinPlayground.Controls
{
    public class SvgImage : SKCanvasView
    {
        public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(string), typeof(SvgImage), default(string), propertyChanged: OnPropertyChanged);

        public string Source
        {
            get => (string)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        public static readonly BindableProperty AssemblyNameProperty = BindableProperty.Create(nameof(AssemblyName), typeof(string), typeof(SvgImage), default(string), propertyChanged: OnPropertyChanged);

        public string AssemblyName
        {
            get => (string)GetValue(AssemblyNameProperty);
            set => SetValue(AssemblyNameProperty, value);
        }
        
        private static void OnPropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var skCanvasView = bindable as SKCanvasView;
            skCanvasView?.InvalidateSurface();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            InvalidateSurface();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            InvalidateSurface();
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);

            try
            {
                var surface = e.Surface;
                var canvas = surface.Canvas;

                canvas.Clear();

                if (string.IsNullOrEmpty(AssemblyName))
                    AssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
                
                if (string.IsNullOrEmpty(Source))
                    return;

                var currentAssembly = Assembly.Load(AssemblyName);
                using (var stream = currentAssembly.GetManifestResourceStream(AssemblyName + "." + Source))
                {
                    var skSvg = new SKSvg();
                    skSvg.Load(stream);

                    var skImageInfo = e.Info;
                    // if (WidthRequest == 0 && HeightRequest == 0)
                    //     canvas.Translate(skImageInfo.Width / 2f, skImageInfo.Height / 2f);
                    // else
                    // {
                    //     canvas.Translate((float)WidthRequest / 2f, (float)HeightRequest / 2f);
                    // }
                    var skRect = skSvg.ViewBox;
                    if (skRect.IsEmpty)
                    {
                        skRect = new SKRect(0, 0, skImageInfo.Width, skImageInfo.Height);
                    }
                    
                    var xRatio = skImageInfo.Width / skRect.Width;
                    var yRatio = skImageInfo.Height / skRect.Height;

                    var ratio = Math.Min(xRatio, yRatio);

                    canvas.Scale(ratio);
                   // canvas.Translate(-skRect.MidX, -skRect.MidY);

                    canvas.DrawPicture(skSvg.Picture);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("OnPaintSurface Exception: " + exc);
            }
        }
    }
}