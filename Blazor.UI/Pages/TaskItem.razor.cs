using AntDesign.Charts;
using Blazor.Model;
using Microsoft.AspNetCore.Components;

namespace Blazor.UI.Pages
{
    public partial class TaskItem
    {
        //任务内容
        [Parameter] public TaskDto Item { get; set; }

        //完成图标事件
        [Parameter] public EventCallback<TaskDto> OnFinish { get; set; }
        public async void OnFinishClick()
        {
            if (OnFinish.HasDelegate)
                await OnFinish.InvokeAsync(Item);
        }

        //条目点击事件
        [Parameter] public EventCallback<TaskDto> OnCard { get; set; }
        public async void OnCardClick()
        {
            if (OnCard.HasDelegate)
                await OnCard.InvokeAsync(Item);
        }

        //删除图标事件
        [Parameter] public EventCallback<TaskDto> OnDel { get; set; }
        public async void OnDelClick()
        {
            if (OnDel.HasDelegate)
                await OnDel.InvokeAsync(Item);
        }

        //重要图标事件
        [Parameter] public EventCallback<TaskDto> OnStar { get; set; }
        public async void OnStarClick()
        {
            if (OnStar.HasDelegate)
                await OnStar.InvokeAsync(Item);
        }

        //是否相似重要图标
        [Parameter] public bool ShowStar { get; set; } = true;

        //支持标题模板
        [Parameter] public RenderFragment TitleTemplate { get; set; }

        //进度迷你图
        readonly RingProgressConfig progressConfig = new RingProgressConfig
        {
            Width = 30,
            Height = 30,
        };
    }
}
