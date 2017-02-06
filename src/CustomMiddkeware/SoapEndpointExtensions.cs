using System.ServiceModel.Channels;
using Microsoft.AspNetCore.Builder;

namespace CustomMiddkeware
{
    public static class SoapEndpointExtensions
    {
        public static IApplicationBuilder UseSoapEndpoint<T>(this IApplicationBuilder builder, string path, Binding binding)
        {
            var encoder = binding.CreateBindingElements().Find<MessageEncodingBindingElement>()?.CreateMessageEncoderFactory().Encoder;
            return builder.UseMiddleware<SoapEndpointMiddleware>(typeof(T), path, encoder);
        }
    }
}
