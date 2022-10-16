using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NET6RazorPageCustomRoutingUsingEFCoreWithPostgreSQL.Entities;

namespace NET6RazorPageCustomRoutingUsingEFCoreWithPostgreSQL.Pages
{
    public class BlogPostModel : PageModel
    {
        private readonly AppDbContext _appDbContext;
        public BlogPostModel(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [BindProperty]
        public BlogPost BlogPost { get; set; }

        public async Task<IActionResult> OnGetAsync(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            BlogPost = await _appDbContext.BlogPosts.FirstOrDefaultAsync(x => x.Url == name);

            if (BlogPost == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
