<!-- default file list -->
*Files to look at*:

* [MainPage.xaml](./CS/SilverlightApplication1/MainPage.xaml) (VB: [MainPage.xaml](./VB/SilverlightApplication1/MainPage.xaml))
* [MainPage.xaml.cs](./CS/SilverlightApplication1/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/SilverlightApplication1/MainPage.xaml))
<!-- default file list end -->
# How to sequentially animate texts in a Digital Gauge control


<p>The following sample demonstrates how to use creeping line and blinking animation effects to imitate the work of the advertising indicator board.</p><br />



<h3>Description</h3>

<p>To accomplish this task, it is necessary to create a  <a href="http://help.devexpress.com/#Silverlight/clsDevExpressXpfGaugesCreepingLineAnimationtopic"><u>CreepingLineAnimation</u></a>   object and assign it to the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesSymbolViewBase_Animationtopic"><u>MatrixView8x14.Animation</u></a>   property. Then handle the <strong>CreepingLineAnimationCompleted</strong> event and assign a new <a href="http://help.devexpress.com/#Silverlight/clsDevExpressXpfGaugesBlinkingAnimationtopic"><u>BlinkingAnimation</u></a> object to the  <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesSymbolViewBase_Animationtopic"><u>MatrixView8x14.Animation</u></a>  property.</p><p><br />
Note that in this example two texts have different number of symbols: the first (&quot;Do you want to learn more?&quot;) -<strong> 26</strong>, the second  (&quot;www.devexpress.com&quot;) - <strong>18</strong> characters. To prevent animation of space symbols in the second text and demonstrate  the creeping line animation for the entire text, the <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesDigitalGaugeControl_SymbolCounttopic"><u>DigitalGaugeControl.SymbolCount</u></a>, <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesCreepingLineAnimation_StartSpacestopic"><u>CreepingLineAnimation.StartSpaces</u></a> and <a href="http://help.devexpress.com/#Silverlight/DevExpressXpfGaugesCreepingLineAnimation_AdditionalSpacestopic"><u>CreepingLineAnimation.AdditionalSpaces</u></a>  properties are set to the values that correspond to the required number of characters.</p><br />


<br/>


