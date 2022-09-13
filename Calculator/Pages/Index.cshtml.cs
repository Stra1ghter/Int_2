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
        int operator1 = Convert.ToInt16(Input.operator1);
        int operator2 = Convert.ToInt16(Input.operator2);
        char operation = Input.operand[0];
        if (operation == '+')
        {
            this.Input.result = (operator1 + operator2).ToString();
        }
        return this.Page();
    }
}
