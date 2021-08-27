using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Binding;
using Tizen.NUI.Components;

namespace BoxStation.box
{
    public partial class Reserve : DialogPage
    {
        

        //이전화면에서 user가 "예약하기"를 누르면 다음 행동요령을 알려줌. 
        //사물함이 isOpen상태가 되고 -> user가 물건을 넣은 후 닫으면 -> !isOpen이 되고-> 이떄의 시간이 기록됨. 
        //user가 예약확인 누른 시간을 저장해야함. 
        public Reserve()
        {
            InitializeComponent();
        }

        Dictionary<string, string> parameters = new Dictionary<string, string>();

        public override bool IsCreateByXaml { get => base.IsCreateByXaml; set => base.IsCreateByXaml = value; }

        public void ShowPopup(Dictionary<string, string> parameters)
        {
            this.parameters = parameters;
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(this);
        }

        private bool View_TouchEvent(object source, TouchEventArgs e)
        {
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Pop();
            return true;
        }

        private bool startReserve_TouchEvent(object source, TouchEventArgs e)
        {
            Create_occupiedLocker("http://52.79.205.194:8000/locker/occupied/create", parameters);
            Reserved reserved = new Reserved();
            NUIApplication.GetDefaultWindow().GetDefaultNavigator().Push(reserved);
            return true;
        }
        private async void Create_occupiedLocker(string uri, Dictionary<string, string> parameters)
        {
            //https://stackoverflow.com/questions/2246694/how-to-convert-json-object-to-custom-c-sharp-object
            //서버로 보낼 데이터
            var encodedContent = new FormUrlEncodedContent(parameters);
            //서버로 데이터를 보내고 받는.. => response로 return
            HttpResponseMessage response = await new HttpClient().PostAsync(uri, encodedContent);
            Console.WriteLine(response.StatusCode);

            //return response;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void CopyFrom(BindableObject other)
        {
            base.CopyFrom(other);
        }

        protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanging(propertyName);
        }

        protected override void OnPropertyChangedWithData(BindableProperty prop)
        {
            base.OnPropertyChangedWithData(prop);
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
        }

        protected override void OnChildAdded(Element child)
        {
            base.OnChildAdded(child);
        }

        protected override void OnChildRemoved(Element child)
        {
            base.OnChildRemoved(child);
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
        }

        public override bool Equals(object o)
        {
            return base.Equals(o);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected override void OnControlStateChanged(ControlStateChangedEventArgs controlStateChangedInfo)
        {
            base.OnControlStateChanged(controlStateChangedInfo);
        }

        public override void ApplyStyle(ViewStyle viewStyle)
        {
            base.ApplyStyle(viewStyle);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        protected override string AccessibilityGetName()
        {
            return base.AccessibilityGetName();
        }

        protected override string AccessibilityGetDescription()
        {
            return base.AccessibilityGetDescription();
        }

        protected override AccessibilityStates AccessibilityCalculateStates()
        {
            return base.AccessibilityCalculateStates();
        }

        protected override int AccessibilityGetActionCount()
        {
            return base.AccessibilityGetActionCount();
        }

        protected override string AccessibilityGetActionName(int index)
        {
            return base.AccessibilityGetActionName(index);
        }

        protected override bool AccessibilityShouldReportZeroChildren()
        {
            return base.AccessibilityShouldReportZeroChildren();
        }

        protected override double AccessibilityGetMinimum()
        {
            return base.AccessibilityGetMinimum();
        }

        protected override double AccessibilityGetCurrent()
        {
            return base.AccessibilityGetCurrent();
        }

        protected override double AccessibilityGetMaximum()
        {
            return base.AccessibilityGetMaximum();
        }

        protected override bool AccessibilitySetCurrent(double value)
        {
            return base.AccessibilitySetCurrent(value);
        }

        protected override double AccessibilityGetMinimumIncrement()
        {
            return base.AccessibilityGetMinimumIncrement();
        }

        protected override bool AccessibilityIsScrollable()
        {
            return base.AccessibilityIsScrollable();
        }

        protected override string AccessibilityGetText(int startOffset, int endOffset)
        {
            return base.AccessibilityGetText(startOffset, endOffset);
        }

        protected override int AccessibilityGetCharacterCount()
        {
            return base.AccessibilityGetCharacterCount();
        }

        protected override int AccessibilityGetCursorOffset()
        {
            return base.AccessibilityGetCursorOffset();
        }

        protected override bool AccessibilitySetCursorOffset(int offset)
        {
            return base.AccessibilitySetCursorOffset(offset);
        }

        protected override AccessibilityRange AccessibilityGetTextAtOffset(int offset, AccessibilityTextBoundary boundary)
        {
            return base.AccessibilityGetTextAtOffset(offset, boundary);
        }

        protected override AccessibilityRange AccessibilityGetSelection(int selectionNumber)
        {
            return base.AccessibilityGetSelection(selectionNumber);
        }

        protected override bool AccessibilityRemoveSelection(int selectionNumber)
        {
            return base.AccessibilityRemoveSelection(selectionNumber);
        }

        protected override bool AccessibilitySetSelection(int selectionNumber, int startOffset, int endOffset)
        {
            return base.AccessibilitySetSelection(selectionNumber, startOffset, endOffset);
        }

        protected override bool AccessibilityCopyText(int startPosition, int endPosition)
        {
            return base.AccessibilityCopyText(startPosition, endPosition);
        }

        protected override bool AccessibilityCutText(int startPosition, int endPosition)
        {
            return base.AccessibilityCutText(startPosition, endPosition);
        }

        protected override bool AccessibilityInsertText(int startPosition, string text)
        {
            return base.AccessibilityInsertText(startPosition, text);
        }

        protected override bool AccessibilitySetTextContents(string newContents)
        {
            return base.AccessibilitySetTextContents(newContents);
        }

        protected override bool AccessibilityDeleteText(int startPosition, int endPosition)
        {
            return base.AccessibilityDeleteText(startPosition, endPosition);
        }

        protected override bool AccessibilityScrollToChild(View child)
        {
            return base.AccessibilityScrollToChild(child);
        }

        protected override int AccessibilityGetSelectedChildrenCount()
        {
            return base.AccessibilityGetSelectedChildrenCount();
        }

        protected override View AccessibilityGetSelectedChild(int selectedChildIndex)
        {
            return base.AccessibilityGetSelectedChild(selectedChildIndex);
        }

        protected override bool AccessibilitySelectChild(int childIndex)
        {
            return base.AccessibilitySelectChild(childIndex);
        }

        protected override bool AccessibilityDeselectSelectedChild(int selectedChildIndex)
        {
            return base.AccessibilityDeselectSelectedChild(selectedChildIndex);
        }

        protected override bool AccessibilityIsChildSelected(int childIndex)
        {
            return base.AccessibilityIsChildSelected(childIndex);
        }

        protected override bool AccessibilitySelectAll()
        {
            return base.AccessibilitySelectAll();
        }

        protected override bool AccessibilityClearSelection()
        {
            return base.AccessibilityClearSelection();
        }

        protected override bool AccessibilityDeselectChild(int childIndex)
        {
            return base.AccessibilityDeselectChild(childIndex);
        }

        protected override bool HandleControlStateOnTouch(Touch touch)
        {
            return base.HandleControlStateOnTouch(touch);
        }

        protected override void InitializeStyle(ViewStyle style = null)
        {
            base.InitializeStyle(style);
        }

        public override void Add(View child)
        {
            base.Add(child);
        }

        public override void Remove(View child)
        {
            base.Remove(child);
        }

        public override View GetChildAt(uint index)
        {
            return base.GetChildAt(index);
        }

        public override uint GetChildCount()
        {
            return base.GetChildCount();
        }

        public override Container GetParent()
        {
            return base.GetParent();
        }

        protected override void ReleaseSwigCPtr(HandleRef swigCPtr)
        {
            base.ReleaseSwigCPtr(swigCPtr);
        }

        public override void OnStageConnection(int depth)
        {
            base.OnStageConnection(depth);
        }

        public override void OnStageDisconnection()
        {
            base.OnStageDisconnection();
        }

        public override void OnSceneConnection(int depth)
        {
            base.OnSceneConnection(depth);
        }

        public override void OnSceneDisconnection()
        {
            base.OnSceneDisconnection();
        }

        public override void OnChildAdd(View view)
        {
            base.OnChildAdd(view);
        }

        public override void OnChildRemove(View view)
        {
            base.OnChildRemove(view);
        }

        public override void OnPropertySet(int index, PropertyValue propertyValue)
        {
            base.OnPropertySet(index, propertyValue);
        }

        public override void OnSizeSet(Vector3 targetSize)
        {
            base.OnSizeSet(targetSize);
        }

        public override void OnSizeAnimation(Animation animation, Vector3 targetSize)
        {
            base.OnSizeAnimation(animation, targetSize);
        }

        public override bool OnTouch(Touch touch)
        {
            return base.OnTouch(touch);
        }

        public override bool OnHover(Hover hover)
        {
            return base.OnHover(hover);
        }

        public override bool OnWheel(Wheel wheel)
        {
            return base.OnWheel(wheel);
        }

        public override void OnSetResizePolicy(ResizePolicyType policy, DimensionType dimension)
        {
            base.OnSetResizePolicy(policy, dimension);
        }

        public override Size2D GetNaturalSize()
        {
            return base.GetNaturalSize();
        }

        public override float CalculateChildSize(View child, DimensionType dimension)
        {
            return base.CalculateChildSize(child, dimension);
        }

        public override float GetHeightForWidth(float width)
        {
            return base.GetHeightForWidth(width);
        }

        public override float GetWidthForHeight(float height)
        {
            return base.GetWidthForHeight(height);
        }

        public override bool RelayoutDependentOnChildren(DimensionType dimension)
        {
            return base.RelayoutDependentOnChildren(dimension);
        }

        public override bool RelayoutDependentOnChildren()
        {
            return base.RelayoutDependentOnChildren();
        }

        public override void OnCalculateRelayoutSize(DimensionType dimension)
        {
            base.OnCalculateRelayoutSize(dimension);
        }

        public override void OnLayoutNegotiated(float size, DimensionType dimension)
        {
            base.OnLayoutNegotiated(size, dimension);
        }

        public override void OnStyleChange(Tizen.NUI.StyleManager styleManager, StyleChangeType change)
        {
            base.OnStyleChange(styleManager, change);
        }

        public override View GetNextFocusableView(View currentFocusedView, FocusDirection direction, bool loopEnabled)
        {
            return base.GetNextFocusableView(currentFocusedView, direction, loopEnabled);
        }

        public override void OnFocusChangeCommitted(View commitedFocusableView)
        {
            base.OnFocusChangeCommitted(commitedFocusableView);
        }

        public override bool OnKeyboardEnter()
        {
            return base.OnKeyboardEnter();
        }

        public override void OnPan(PanGesture pan)
        {
            base.OnPan(pan);
        }

        public override void OnTap(TapGesture tap)
        {
            base.OnTap(tap);
        }

        protected override bool AccessibilityDoAction(string name)
        {
            return base.AccessibilityDoAction(name);
        }

        public override void OnInitialize()
        {
            base.OnInitialize();
        }

        public override bool OnKey(Key key)
        {
            return base.OnKey(key);
        }

        public override void OnRelayout(Vector2 size, RelayoutContainer container)
        {
            base.OnRelayout(size, container);
        }

        public override void OnFocusGained()
        {
            base.OnFocusGained();
        }

        public override void OnFocusLost()
        {
            base.OnFocusLost();
        }

        protected override void OnUpdate()
        {
            base.OnUpdate();
        }

        protected override void OnThemeChangedEvent(object sender, Tizen.NUI.Components.StyleManager.ThemeChangeEventArgs e)
        {
            base.OnThemeChangedEvent(sender, e);
        }

        protected override ViewStyle CreateViewStyle()
        {
            return base.CreateViewStyle();
        }

        protected override void OnThemeChanged(object sender, ThemeChangedEventArgs e)
        {
            base.OnThemeChanged(sender, e);
        }

        protected override void Dispose(DisposeTypes type)
        {
            base.Dispose(type);
        }
    }
}
