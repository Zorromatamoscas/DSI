﻿#pragma checksum "C:\Users\pedro\OneDrive\Documentos\FP2\DSI\Dsi Proyect\Dsi Proyect\TeamSelect.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "418F59E347F84F41D56FE417A924F31F99C4F3EFF6432388AB364E43AEEF6D4C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dsi_Proyect
{
    partial class TeamSelect : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TeamSelect_obj7_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITeamSelect_Bindings
        {
            private global::Dsi_Proyect.Personajes dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj7;
            private global::Windows.UI.Xaml.Controls.TextBlock obj8;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj8TextDisabled = false;

            public TeamSelect_obj7_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 37 && columnNumber == 32)
                {
                    isobj8TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 7: // TeamSelect.xaml line 25
                        this.obj7 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.Grid)target);
                        break;
                    case 8: // TeamSelect.xaml line 37
                        this.obj8 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj7.Target as global::Windows.UI.Xaml.Controls.Grid).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Dsi_Proyect.Personajes) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ITeamSelect_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Dsi_Proyect.Personajes)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Dsi_Proyect.Personajes obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Nombre(obj.Nombre, phase);
                    }
                }
            }
            private void Update_Nombre(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // TeamSelect.xaml line 37
                    if (!isobj8TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj8, obj, null);
                    }
                }
            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class TeamSelect_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ITeamSelect_Bindings
        {
            private global::Dsi_Proyect.TeamSelect dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj10;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj10ItemsSourceDisabled = false;

            private TeamSelect_obj1_BindingsTracking bindingsTracking;

            public TeamSelect_obj1_Bindings()
            {
                this.bindingsTracking = new TeamSelect_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 153 && columnNumber == 19)
                {
                    isobj10ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 10: // TeamSelect.xaml line 148
                        this.obj10 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // ITeamSelect_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Dsi_Proyect.TeamSelect)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Dsi_Proyect.TeamSelect obj, int phase)
            {
                this.Update_Dsi_Proyect_ListaPj_personajes(global::Dsi_Proyect.ListaPj.personajes, phase);
            }
            private void Update_Dsi_Proyect_ListaPj_personajes(global::System.Collections.Generic.List<global::Dsi_Proyect.Personajes> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // TeamSelect.xaml line 148
                    if (!isobj10ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj10, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class TeamSelect_obj1_BindingsTracking
            {
                private global::System.WeakReference<TeamSelect_obj1_Bindings> weakRefToBindingObj; 

                public TeamSelect_obj1_BindingsTracking(TeamSelect_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<TeamSelect_obj1_Bindings>(obj);
                }

                public TeamSelect_obj1_Bindings TryGetBindingObject()
                {
                    TeamSelect_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // TeamSelect.xaml line 12
                {
                    this.Tabs = (global::Windows.UI.Xaml.Style)(target);
                }
                break;
            case 9: // TeamSelect.xaml line 56
                {
                    global::Windows.UI.Xaml.Controls.Grid element9 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element9).KeyUp += this.OnKeyUp;
                }
                break;
            case 10: // TeamSelect.xaml line 148
                {
                    this.ListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListView).SelectionChanged += this.ListView_SelectionChanged;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListView).ItemClick += this.ListView_ItemClick;
                    ((global::Windows.UI.Xaml.Controls.ListView)this.ListView).DragItemsStarting += this.ListView_DragItemsStarting;
                }
                break;
            case 11: // TeamSelect.xaml line 124
                {
                    this.myCanvas = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 12: // TeamSelect.xaml line 128
                {
                    this.Ally_button_1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ally_button_1).DragOver += this.myCanvas_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ally_button_1).Drop += this.myCanvas_Drop;
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ally_button_1).Click += this.Ally1_Click;
                }
                break;
            case 13: // TeamSelect.xaml line 131
                {
                    this.Ally_button_2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ally_button_2).DragOver += this.myCanvas_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ally_button_2).Drop += this.myCanvas_Drop;
                    ((global::Windows.UI.Xaml.Controls.Button)this.Ally_button_2).Click += this.Ally2_Click;
                }
                break;
            case 14: // TeamSelect.xaml line 135
                {
                    global::Windows.UI.Xaml.Controls.Button element14 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element14).Click += this.Button_Click;
                }
                break;
            case 15: // TeamSelect.xaml line 132
                {
                    this.allySpace2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 16: // TeamSelect.xaml line 129
                {
                    this.allySpace1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17: // TeamSelect.xaml line 78
                {
                    this.backButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.backButton).Click += this.backButton_Click;
                }
                break;
            case 18: // TeamSelect.xaml line 115
                {
                    global::Windows.UI.Xaml.Controls.Button element18 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element18).Click += this.Sword_Click;
                }
                break;
            case 19: // TeamSelect.xaml line 116
                {
                    global::Windows.UI.Xaml.Controls.Button element19 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element19).Click += this.Shield_Click;
                }
                break;
            case 20: // TeamSelect.xaml line 117
                {
                    global::Windows.UI.Xaml.Controls.Button element20 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element20).Click += this.Bow_Click;
                }
                break;
            case 21: // TeamSelect.xaml line 91
                {
                    this.pjImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 22: // TeamSelect.xaml line 99
                {
                    this.statStack = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 23: // TeamSelect.xaml line 100
                {
                    this.HP = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 24: // TeamSelect.xaml line 101
                {
                    this.ATK = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 25: // TeamSelect.xaml line 102
                {
                    this.DEF = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 26: // TeamSelect.xaml line 103
                {
                    this.Lv = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 27: // TeamSelect.xaml line 104
                {
                    this.Type = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // TeamSelect.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    TeamSelect_obj1_Bindings bindings = new TeamSelect_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 7: // TeamSelect.xaml line 25
                {                    
                    global::Windows.UI.Xaml.Controls.Grid element7 = (global::Windows.UI.Xaml.Controls.Grid)target;
                    TeamSelect_obj7_Bindings bindings = new TeamSelect_obj7_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element7.DataContext);
                    element7.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element7, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element7, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

