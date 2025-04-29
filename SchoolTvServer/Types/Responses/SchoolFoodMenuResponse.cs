using SkolmatenApi.Types;

namespace SchoolTvServer.Types.Responses;

public record SchoolFoodMenuResponse
{
    public required IEnumerable<SchoolFoodDayResponse> Days { get; init; }

    public static SchoolFoodMenuResponse FromCache(SchoolFoodMenuCache cache)
    {
        List<SchoolFoodDayResponse> days = [];
        
        foreach (Menu menu in cache.Menus)
        {
            if (menu.WeekState == null)
                continue;
            
            foreach (MenuDay day in menu.WeekState.Days)
            {
                days.Add(new SchoolFoodDayResponse
                {
                    Date = day.Date,
                    Meals = day.Meals.Select(m => m.Name)
                });
            }
        }
        
        return new SchoolFoodMenuResponse
        {
            Days = days
        };
    }
}