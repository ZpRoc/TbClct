# Toolbox Collection

[TOC]

## MainForm

### 菜单栏

-   文件
-   工具
-   设置
-   激活
-   帮助

### 状态栏

-   时间
-   进度条

## BaseForm

### BaseForm

-   设置字体：`YaHei Consolas Hybrid, 12pt`
-   设置图标：`ZpRoc.ico`
-   设置窗体起始位置：`CenterScreen`

### OkCancelForm

-   继承于 `BaseForm`
-   设置键盘事件：`KeyPreview = True`
-   添加控件
    -   `buttonOK `：确定按钮 (Public)
    -   `buttonCancel`：取消按钮 (Public)
-   注册事件
    -   `buttonOK_Click`：确定按钮 单击事件
    -   `buttonCancel_Click`：取消按钮 单击事件
    -   `OkCancelForm_KeyDown`：快捷键，回车 确定 + Esc 取消

### ToolForm

-   继承于 ` OkCancelForm`
-   添加控件
    -   `labelTitle`：显示窗体名称，`Font = YaHei Consolas Hybrid, 14.25pt, style=Bold`
    -   `panelMain`：操作区 (界面美化，分割标题和按钮)

## SysForm

### HelpForm

-   帮助窗体：解释工具使用、激活步骤等
-   继承于 `BaseForm.OkCancelForm`

### AboutForm

-   关于窗体：显示软件信息、作者信息等
-   继承于 `BaseForm.OkCancelForm`

### DispForm

-   显示窗体：
-   继承于 `BaseForm.OkCancelForm`

### InputForm

-   输入窗体：
-   继承于 `BaseForm.OkCancelForm`

























