using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;


    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    [BindProperty]
    public Input Input { get; set; } = new Input();

    public async Task<IActionResult> OnGet()
    {
        return this.Page();
    }

    public async Task<IActionResult> OnPost()
    {
        int operand1 = Convert.ToInt16(Input.operand1);
        int operand2 = Convert.ToInt16(Input.operand2);
        char operation = Input.Operator[0];
        if (operation == '+')
        {
            this.Input.result = (operand1 + operand2).ToString();
        }

        return this.Page();
    }
}
