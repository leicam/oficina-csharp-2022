using Microsoft.AspNetCore.Mvc;
using System;

namespace Facec.Apresentacao.Controllers
{
    public abstract class AbstractController : ControllerBase
    {
        protected IActionResult InvokeMethod<TResult>(
            Func<TResult> method)
        {
            try
            {
                return Ok(method.Invoke());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        protected IActionResult InvokeMethod<T, TResult>(
            Func<T, TResult> method, T args)
        {
            try
            {
                return Ok(method.Invoke(args));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}