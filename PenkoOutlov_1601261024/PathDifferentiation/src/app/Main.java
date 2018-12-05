package app;

import graph.Node;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

    private static int totalEdges = 0;

    private static int currentEdgeCount = 0;

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);

        int m = input.nextInt();
        int s = input.nextInt();
        int t = input.nextInt();
        int k = input.nextInt();

        List<Node> nodes = new ArrayList<>();

        for (int i = 0; i < m; i++) {
            int a = input.nextInt();
            int b = input.nextInt();

            Node start = nodes.stream()
                    .filter(e -> e.getValue() == a)
                    .findFirst()
                    .orElse(new Node(a));

            Node end = nodes.stream()
                    .filter(e -> e.getValue() == b)
                    .findFirst()
                    .orElse(new Node(b));

            start.addNode(end);

            if (!nodes.contains(start)) {
                nodes.add(start);
            }

            if (!nodes.contains(end)) {
                nodes.add(end);
            }
        }

        input.close();

        Node sNode = nodes.stream()
                .filter(e -> e.getValue() == s)
                .findFirst()
                .orElse(null);

        for (Node node : sNode.getNodes()) {
            currentEdgeCount++;

            System.out.print(s + " -> ");

            findPaths(node, t);

            node.setTraversed(true);
        }

        if (totalEdges >= 1 && totalEdges <= k) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

    private static boolean findPaths(Node current, int value) {
        if (current.isTraversed()) {
            System.out.println("Already traversed");
            currentEdgeCount = 0;

            return false;
        }

        if (current.getValue() == value) {
            System.out.println(value);
            totalEdges += currentEdgeCount;
            currentEdgeCount = 0;

            return true;
        }

        if (current.getNodes().isEmpty()) {
            System.out.println(current.getValue());
            currentEdgeCount = 0;

            return false;
        }

        boolean pathFound = false;

        for (Node next : current.getNodes()) {
            currentEdgeCount++;

            System.out.print(current.getValue() + " -> ");

            if (findPaths(next, value)) {
                pathFound = true;

                if (next.getValue() != value) {
                    next.setTraversed(true);
                }

                break;
            }
        }

        return pathFound;
    }
}
