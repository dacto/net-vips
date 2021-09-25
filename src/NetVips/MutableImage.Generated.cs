//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     libvips version: 8.11.4
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetVips
{
    public sealed partial class MutableImage
    {
        #region auto-generated functions

        /// <summary>
        /// Draw a circle on an image.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawCircle(ink, cx, cy, radius, fill: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="cx">Centre of draw_circle.</param>
        /// <param name="cy">Centre of draw_circle.</param>
        /// <param name="radius">Radius in pixels.</param>
        /// <param name="fill">Draw a solid object.</param>
        public void DrawCircle(double[] ink, int cx, int cy, int radius, bool? fill = null)
        {
            var options = new VOption();

            if (fill.HasValue)
            {
                options.Add(nameof(fill), fill);
            }

            this.Call("draw_circle", options, ink, cx, cy, radius);
        }

        /// <summary>
        /// Flood-fill an area.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawFlood(ink, x, y, test: Image, equal: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="x">DrawFlood start point.</param>
        /// <param name="y">DrawFlood start point.</param>
        /// <param name="test">Test pixels in this image.</param>
        /// <param name="equal">DrawFlood while equal to edge.</param>
        public void DrawFlood(double[] ink, int x, int y, Image test = null, bool? equal = null)
        {
            var options = new VOption();

            if (test != null)
            {
                options.Add(nameof(test), test);
            }

            if (equal.HasValue)
            {
                options.Add(nameof(equal), equal);
            }

            this.Call("draw_flood", options, ink, x, y);
        }

        /// <summary>
        /// Flood-fill an area.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawFlood(ink, x, y, out var left, test: Image, equal: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="x">DrawFlood start point.</param>
        /// <param name="y">DrawFlood start point.</param>
        /// <param name="left">Left edge of modified area.</param>
        /// <param name="test">Test pixels in this image.</param>
        /// <param name="equal">DrawFlood while equal to edge.</param>
        public void DrawFlood(double[] ink, int x, int y, out int left, Image test = null, bool? equal = null)
        {
            var options = new VOption();

            if (test != null)
            {
                options.Add(nameof(test), test);
            }

            if (equal.HasValue)
            {
                options.Add(nameof(equal), equal);
            }

            options.Add("left", true);

            var results = this.Call("draw_flood", options, ink, x, y) as object[];

            var opts = results?[1] as VOption;
            left = opts?["left"] is int out1 ? out1 : 0;
        }

        /// <summary>
        /// Flood-fill an area.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawFlood(ink, x, y, out var left, out var top, test: Image, equal: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="x">DrawFlood start point.</param>
        /// <param name="y">DrawFlood start point.</param>
        /// <param name="left">Left edge of modified area.</param>
        /// <param name="top">top edge of modified area.</param>
        /// <param name="test">Test pixels in this image.</param>
        /// <param name="equal">DrawFlood while equal to edge.</param>
        public void DrawFlood(double[] ink, int x, int y, out int left, out int top, Image test = null, bool? equal = null)
        {
            var options = new VOption();

            if (test != null)
            {
                options.Add(nameof(test), test);
            }

            if (equal.HasValue)
            {
                options.Add(nameof(equal), equal);
            }

            options.Add("left", true);
            options.Add("top", true);

            var results = this.Call("draw_flood", options, ink, x, y) as object[];

            var opts = results?[1] as VOption;
            left = opts?["left"] is int out1 ? out1 : 0;
            top = opts?["top"] is int out2 ? out2 : 0;
        }

        /// <summary>
        /// Flood-fill an area.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawFlood(ink, x, y, out var left, out var top, out var width, test: Image, equal: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="x">DrawFlood start point.</param>
        /// <param name="y">DrawFlood start point.</param>
        /// <param name="left">Left edge of modified area.</param>
        /// <param name="top">top edge of modified area.</param>
        /// <param name="width">width of modified area.</param>
        /// <param name="test">Test pixels in this image.</param>
        /// <param name="equal">DrawFlood while equal to edge.</param>
        public void DrawFlood(double[] ink, int x, int y, out int left, out int top, out int width, Image test = null, bool? equal = null)
        {
            var options = new VOption();

            if (test != null)
            {
                options.Add(nameof(test), test);
            }

            if (equal.HasValue)
            {
                options.Add(nameof(equal), equal);
            }

            options.Add("left", true);
            options.Add("top", true);
            options.Add("width", true);

            var results = this.Call("draw_flood", options, ink, x, y) as object[];

            var opts = results?[1] as VOption;
            left = opts?["left"] is int out1 ? out1 : 0;
            top = opts?["top"] is int out2 ? out2 : 0;
            width = opts?["width"] is int out3 ? out3 : 0;
        }

        /// <summary>
        /// Flood-fill an area.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawFlood(ink, x, y, out var left, out var top, out var width, out var height, test: Image, equal: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="x">DrawFlood start point.</param>
        /// <param name="y">DrawFlood start point.</param>
        /// <param name="left">Left edge of modified area.</param>
        /// <param name="top">top edge of modified area.</param>
        /// <param name="width">width of modified area.</param>
        /// <param name="height">height of modified area.</param>
        /// <param name="test">Test pixels in this image.</param>
        /// <param name="equal">DrawFlood while equal to edge.</param>
        public void DrawFlood(double[] ink, int x, int y, out int left, out int top, out int width, out int height, Image test = null, bool? equal = null)
        {
            var options = new VOption();

            if (test != null)
            {
                options.Add(nameof(test), test);
            }

            if (equal.HasValue)
            {
                options.Add(nameof(equal), equal);
            }

            options.Add("left", true);
            options.Add("top", true);
            options.Add("width", true);
            options.Add("height", true);

            var results = this.Call("draw_flood", options, ink, x, y) as object[];

            var opts = results?[1] as VOption;
            left = opts?["left"] is int out1 ? out1 : 0;
            top = opts?["top"] is int out2 ? out2 : 0;
            width = opts?["width"] is int out3 ? out3 : 0;
            height = opts?["height"] is int out4 ? out4 : 0;
        }

        /// <summary>
        /// Paint an image into another image.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawImage(sub, x, y, mode: Enums.CombineMode));
        /// </code>
        /// </example>
        /// <param name="sub">Sub-image to insert into main image.</param>
        /// <param name="x">Draw image here.</param>
        /// <param name="y">Draw image here.</param>
        /// <param name="mode">Combining mode.</param>
        public void DrawImage(Image sub, int x, int y, Enums.CombineMode? mode = null)
        {
            var options = new VOption();

            if (mode.HasValue)
            {
                options.Add(nameof(mode), mode);
            }

            this.Call("draw_image", options, sub, x, y);
        }

        /// <summary>
        /// Draw a line on an image.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawLine(ink, x1, y1, x2, y2));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="x1">Start of draw_line.</param>
        /// <param name="y1">Start of draw_line.</param>
        /// <param name="x2">End of draw_line.</param>
        /// <param name="y2">End of draw_line.</param>
        public void DrawLine(double[] ink, int x1, int y1, int x2, int y2)
        {
            this.Call("draw_line", ink, x1, y1, x2, y2);
        }

        /// <summary>
        /// Draw a mask on an image.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawMask(ink, mask, x, y));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="mask">Mask of pixels to draw.</param>
        /// <param name="x">Draw mask here.</param>
        /// <param name="y">Draw mask here.</param>
        public void DrawMask(double[] ink, Image mask, int x, int y)
        {
            this.Call("draw_mask", ink, mask, x, y);
        }

        /// <summary>
        /// Paint a rectangle on an image.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawRect(ink, left, top, width, height, fill: bool));
        /// </code>
        /// </example>
        /// <param name="ink">Color for pixels.</param>
        /// <param name="left">Rect to fill.</param>
        /// <param name="top">Rect to fill.</param>
        /// <param name="width">Rect to fill.</param>
        /// <param name="height">Rect to fill.</param>
        /// <param name="fill">Draw a solid object.</param>
        public void DrawRect(double[] ink, int left, int top, int width, int height, bool? fill = null)
        {
            var options = new VOption();

            if (fill.HasValue)
            {
                options.Add(nameof(fill), fill);
            }

            this.Call("draw_rect", options, ink, left, top, width, height);
        }

        /// <summary>
        /// Blur a rectangle on an image.
        /// </summary>
        /// <example>
        /// <code language="lang-csharp">
        /// image.Mutate(x => x.DrawSmudge(left, top, width, height));
        /// </code>
        /// </example>
        /// <param name="left">Rect to fill.</param>
        /// <param name="top">Rect to fill.</param>
        /// <param name="width">Rect to fill.</param>
        /// <param name="height">Rect to fill.</param>
        public void DrawSmudge(int left, int top, int width, int height)
        {
            this.Call("draw_smudge", left, top, width, height);
        }

        #endregion
    }
}
