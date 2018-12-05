
public class Link {
	private double length;
	private Node toNode;


	public Link(Node to) {
		this.toNode = to;
	}

	public Link(Node to, double lenght) {
		this(to);
		this.length = lenght;
	}

	

	public double getLength() {
		return length;
	}

	public void setLength(double lenght) {
		this.length = lenght;
	}

	public Node getToNode() {
		return toNode;
	}

	public void setToNode(Node to) {
		this.toNode = to;
	}

	
}
