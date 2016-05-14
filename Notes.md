# C# for Unity3D 
Cheatsheet for using C# in Unity3D
Unity3D uses the Mono Runtime which supports basically the Language Level 4.

# Namespaces
Grouping your code to a logical Unit for the compiler.
__Important for sharing and reusing code!__ Avoid naming conflicts.  

```cs

namespace <NamespaceRootName>.<SubNameSpaceName> {

	// classes
	// delegates
	// enums
	// interfaces 

}

```

# Classes and Concepts of OOP

## Classes and inheritance

```cs

public class <ClassName> {
	
	void Methode(){

		// a methode could be overridden in the child class

	}

	string MethodeReturningAString(){

		return "aString";
	}
}
```

```cs

public abstract class <AAbstractClassName> {
	
	abstract void <MethodeName>(); // Methode without implementation to force child classes to implement

	virtual void Methode(){

		// a methode could be overridden in the child class

	}
}

```


```cs
public class <AUnityEntity> : Monobehavior {
	
}

```

Use abstract classes as Unity entity base classes

```cs
public abstract class <AUnityEntity> : Monobehavior {
	
}

``` 

### Properties vs Fields


```cs
    private float NameOfAFloatField; // field

    public float PropertyEncapsulatesField
    {
        get { return NameOfAFloatField; }
        set { 
        	NameOfAFloatField = value;

        	if (SomethingIsWrongWithThe(value))
        		DoSomethingSpecial(); 
        }
    }
```

### Methods

## Interfaces

```cs

public interface <InterfaceName> {
	
	void <MethodeName>();
}

```

# Statical Typed Function Pointers

## Delegates 

```cs

// a custom delegate
delegate void <ACustomDelegateName> (<ClassName> argument);

// abstract generic delegates
Action<T> <FunctionPointerName>;

void CallToDelegate(){

	if(<FunctionPointerName> != null)
		<FunctionPointerName>();	
}

```

## Events

Code level publish/subscribe concept

```cs

event Action<T> <EventName>;

void RaiseTheEvent(T parameter){

	// publish the event

	if(<EventName> != null)
		<EventName>(parameter);	
}


// somewhere in the code subscribe to the event

<eventName> += myMethode; // don't use parenthesis here

```

More examples: [Microsoft Docu](https://msdn.microsoft.com/de-de/library/orm-9780596527570-03-04.aspx)

# Anonymous functions and Lambda expressions

```cs

<anObject>.<eventName> += (argument) => { DoWhateverYouWantWithThe(argument); }; 

```

# Attributes

