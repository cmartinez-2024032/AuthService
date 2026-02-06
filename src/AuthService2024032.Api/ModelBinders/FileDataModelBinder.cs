using AuthService2024032.Api.Models;
using AuthService2024032.Application.interfaces;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace AuthService2024032.Api.ModelBinders;

public class FileDataModelBinder : IModelBinder
{
    public Task BindModelAsync(ModelBindingContext bindingContext)
    {
        ArgumentNullException.ThrowIfNull(bindingContext);

        if (!typeof(IFileData).IsAssignableFrom(bindingContext.ModelType))

        {
            return Task.CompletedTask;
        }

        var request = bindingContext.HttpContext.Request;

        var file = request.Form.Files.GetFile(bindingContext.FieldName);

        if(file != null && file.Length > 0)
        {
            
            var fileData = new FormFileAdapter(file);
            bindingContext.Result = ModelBindingResult.Success(fileData);
        }
        else
        {
            bindingContext.Result = ModelBindingResult.Success(null);
        }
        return Task.CompletedTask;
    }
}


public class FileDataModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null) throw new ArgumentNullException(nameof(context));

            // Comprueba si el tipo de modelo implementa IFileData
            if (typeof(IFileData).IsAssignableFrom(context.Metadata.ModelType))
            {
                return new FileDataModelBinder();
            }

            return null;
        }
}