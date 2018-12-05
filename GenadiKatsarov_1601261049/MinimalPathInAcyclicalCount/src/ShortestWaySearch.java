import java.util.ArrayList;



public class ShortestWaySearch extends ASearch {
	public ShortestWaySearch(Graph graph) {
		super(graph);

	}
  
    @Override
	public boolean search(String from, String to) {
		myGraph.resetGraph();
		if (!myMap.containsKey(from) || !myMap.containsKey(to)) {
			return false;
		}
		boolean havePath = false;
		Node fromNode = myMap.get(from);
		fromNode.setExpense(0);

		ArrayList<Node> queue = new ArrayList<Node>();
		queue.add(fromNode);
		while (!queue.isEmpty()) {
			Node temp = queue.get(0);
			queue.remove(0);
			
			if (temp.getName().equals(to)) {

				havePath = true;
			}
			temp.setTested(true);
			for (Link l : temp.getLinks()) {
				double expense = temp.getExpense() + l.getLength();
				if ((l.getToNode().getExpense() > expense )) {
					l.getToNode().setExpense(expense);
					l.getToNode().setParent(temp);
				}
				if (!l.getToNode().isTested() && !queue.contains(l.getToNode())) {
					queue.add(l.getToNode());
				}
			}
			temp.setExpanded(true);
		}
		if (havePath) {
			myGraph.setPath(parentPrintPath(myMap.get(to), myMap.get(from)));
			return true;
		}

		return false;
	}
}
